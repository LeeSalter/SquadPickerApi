using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SquadPicker.Models;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public ActionResult<List<Player>> GetTeam(Guid id)
        {
            var response = _teamService.GetTeam(id);
            if (response.Success)
                return response.Payload;

            return NoContent();
            
        }

        [HttpPost]
        [Route("saveteam")]
        public ActionResult<Team> SaveTeam([FromBody] TeamModel model)
        {
            var response = _teamService.CreateTeam(model);
            if (response.Success)
                return response.Payload;

            return NoContent();
        }
    }
}
