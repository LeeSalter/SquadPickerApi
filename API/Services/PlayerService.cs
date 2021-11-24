using API.Models;
using Microsoft.AspNetCore.Http;
using SquadPicker.Data;
using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public class PlayerService:IPlayerService
    {
        private readonly SquadPickerContext _db;
        private readonly Guid _userId;
        public PlayerService(SquadPickerContext db, IHttpContextAccessor context)
        {
            _db = db;
            _userId=Guid.Parse(context.HttpContext.User.Identity.Name);

        }

        public List<Player> GetPlayers()
        {
            return _db.Players.Where(x => !x.Deleted && x.UserId== _userId).OrderBy(x => x.Position).ToList();
        }

        public DbResponse<Player> AddPlayer(string name, Position position)
        {
            var player = new Player();
            player.UserId = _userId;
            player.Id = GetNextId();
            player.Name = name;
            player.Position = position;
            player.Deleted = false;

            try
            {
                _db.Players.Add(player);
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                //TODO: Log the exception.
                return new DbResponse<Player>(false, ex.Message, null);
            }

            return new DbResponse<Player>(true, string.Empty, player);
        }

        public DbResponse<bool> RemovePlayer(int id)
        {
            var response= GetPlayer(id);
            if (!response.Success)
                return new DbResponse<bool>(true,string.Empty,true);

            var player = response.Payload;
            player.Deleted = true;
            _db.Players.Update(player);

            try
            {
                _db.SaveChanges();
                return new DbResponse<bool>(true, string.Empty, true);
            }
            catch(Exception ex)
            {
                return new DbResponse<bool>(false, ex.Message, false);
            }
        }

        public DbResponse<Player> GetPlayer(int id)
        {
            var player= _db.Players.Find(id);
            if (player != null)
                return new DbResponse<Player>(false, "Player not found", null);

            return new DbResponse<Player>(true, string.Empty, player);
        }

        private int GetNextId()
        {
            //Not thread safe - in production would introduce the double-check locking pattern
            //or make the column an identity column (but I don't really like those).
            return _db.Players.Max(x => x.Id) + 1;
        }
    }

    public interface IPlayerService
    {
        List<Player> GetPlayers();
        DbResponse<Player> GetPlayer(int id);
        DbResponse<Player> AddPlayer(string name, Position position);
        DbResponse<bool> RemovePlayer(int id);
    }
}
