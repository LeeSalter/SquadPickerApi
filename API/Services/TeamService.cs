using API.Models;
using SquadPicker.Data;
using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class TeamService : ITeamService
    {
        private readonly SquadPickerContext _db;
        public TeamService(SquadPickerContext db)
        {
            _db = db;
        }

        public DbResponse<Team> CreateTeam(TeamModel model)
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

            try
            {
                _db.Teams.Add(team);
                _db.SaveChanges();

                return new DbResponse<Team>(true, string.Empty, team);
            }
            catch (Exception ex)
            {
                return new DbResponse<Team>(false, ex.Message, null);
            }
        }

        public DbResponse<List<Player>> GetTeam(Guid id)
        {
            var squad = _db.Players;
            var team = _db.TeamPlayers.Where(x => x.TeamId == id).ToList();
            if (team == null)
                return new DbResponse<List<Player>>(true, string.Empty,
                        squad.OrderBy(x => x.Position).ToList());

            foreach (var tp in team)
            {
                squad.First(x => x.Id == tp.PlayerId).Selected = true;
            }

            return new DbResponse<List<Player>>(true, string.Empty,
                        squad.OrderBy(x => x.Position).ToList());
        }

    }

    public interface ITeamService
    {
        DbResponse<Team> CreateTeam(TeamModel model);
        DbResponse<List<Player>> GetTeam(Guid id);
    }
}
