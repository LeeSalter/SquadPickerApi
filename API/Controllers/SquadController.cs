using SquadPicker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SquadPicker.Data;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class SquadController : ControllerBase
    {
        private readonly SquadPickerContext _db;
        public SquadController(SquadPickerContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Player> GetPlayers()
        {
            //Get the players out of the db
            return _db.Players.OrderBy(p => p.Position).ToList();
        }

        [HttpPost]
        [Route("api/[controller]/createplayer")]
        public Player CreatePlayer(string name, Position position)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            var player = new Player();
            player.Id = GetNextId();
            player.Name = name;
            player.Position = position;

            //Add the player to the db.
            _db.Players.Add(player);
            _db.SaveChanges();

            return player;
        }

        [HttpPost]
        [Route("api/[controller]/saveteam")]
        public Team SaveTeam(Guid formationId, Guid userId, List<int> players)
        {
            if (players == null)
                throw new ArgumentNullException(nameof(players));

            if (players.Count != 11)
                throw new ArgumentException("A team must have 11 players", nameof(players));

            Team team = new Team();
            team.Id = Guid.NewGuid();
            team.User = _db.Users.Find(userId);
            team.CreatedDateUtc = DateTime.UtcNow;
            team.Formation = _db.Formations.Find(formationId);                        

            _db.Teams.Add(team);
            _db.SaveChanges();

            return team;
        }

        private int GetNextId()
        {
            return _db.Players.Max(p => p.Id) + 1;            
        }
    }
}
