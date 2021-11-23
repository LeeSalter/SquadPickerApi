using SquadPicker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SquadPicker.Data;
using Microsoft.AspNetCore.Cors;
using API.Models;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize]
        [HttpPost]
        [Route("saveteam")]
        public Team SaveTeam([FromBody]TeamModel model)
        {
            if (model.PlayerIds == null)
                throw new ArgumentNullException(nameof(model.PlayerIds));

            if (model.PlayerIds.Count != 11)
                throw new ArgumentException("A team must have 11 players", nameof(model.PlayerIds));

            Team team = new Team();
            team.Id = Guid.NewGuid();
            team.User = _db.Users.Find(model.UserId);
            team.CreatedDateUtc = DateTime.UtcNow;
            team.Formation = _db.Formations.Find(model.FormationId);
            foreach (var id in model.PlayerIds)
            {
                TeamPlayer tp = new TeamPlayer
                {
                    TeamId = team.Id,
                    PlayerId = id,
                    Id = Guid.NewGuid()
                };
                team.TeamPlayers.Add(tp);
            }
            _db.Teams.Add(team);
            _db.SaveChanges();
            
            return team;
        }

        [HttpGet]
        [Route("api/[controller]/teams/Id")]
        public List<Player> GetTeam(Guid Id)
        {
            var squad = _db.Players;
            var team = _db.TeamPlayers.Where(x => x.TeamId == Id).ToList();
            if (team == null)
                return squad.OrderBy(x => x.Position).ToList();

            foreach(var tp in team)
            {
                squad.First(x => x.Id == tp.PlayerId).Selected = true;
            }

            return squad.OrderBy(x => x.Position).ToList();
        }

        private int GetNextId()
        {
            return _db.Players.Max(p => p.Id) + 1;            
        }
    }
}
