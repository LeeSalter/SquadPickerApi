using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
        private readonly Guid _userId;
        public TeamService(SquadPickerContext db, IHttpContextAccessor context)
        {
            _db = db;
            _userId= Guid.Parse(context.HttpContext.User.Identity.Name);
        }

        public DbResponse<Team> CreateTeam(SaveTeamModel model)
        {
            if (model.PlayerIds == null)
                throw new ArgumentNullException(nameof(model.PlayerIds));

            if (model.PlayerIds.Count != 11)
                throw new ArgumentException("A team must have 11 players", nameof(model.PlayerIds));

            Team team = new Team();
            team.Id = Guid.NewGuid();
            team.User = _db.Users.Find(_userId);
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

        public DbResponse<LoadTeamModel> GetTeam(Guid id)
        {
            var squad = _db.Players;
            var team = _db.Teams.Include(x => x.Formation).FirstOrDefault(x => x.Id == id);
            var players = _db.TeamPlayers.Where(x => x.TeamId == id).ToList();
            if (team == null)
            {
                var defaultModel = new LoadTeamModel();
                defaultModel.Formation = _db.Formations.FirstOrDefault();
                defaultModel.Players = squad.OrderBy(x => x.Position).ToList();
                return new DbResponse<LoadTeamModel>(true, string.Empty,
                        defaultModel);
            }

            foreach (var tp in players)
            {
                squad.First(x => x.Id == tp.PlayerId).Selected = true;
            }

            var model = new LoadTeamModel();
            model.Players= squad.OrderBy(x => x.Position).ToList();
            model.Formation = team.Formation;

            return new DbResponse<LoadTeamModel>(true, string.Empty,
                        model);
        }


        public DbResponse<List<Team>> GetTeams()
        {
            var teams = _db.Teams.Include(x=>x.Formation).Where(x => x.UserId == _userId).OrderByDescending(x=>x.CreatedDateUtc).ToList();
            return new DbResponse<List<Team>>(true, string.Empty, teams);
        }
    }

    public interface ITeamService
    {
        DbResponse<Team> CreateTeam(SaveTeamModel model);
        DbResponse<LoadTeamModel> GetTeam(Guid id);
        DbResponse<List<Team>> GetTeams();
    }
}
