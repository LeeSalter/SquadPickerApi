using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Authorize]
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class SquadController : ControllerBase
    {
        private readonly IPlayerService _playerService;
       
        public SquadController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public ActionResult<List<Player>> GetPlayers()
        {
            //Get the players out of the db
            var players = _playerService.GetPlayers();
            if (players.Any())
                return players;

            return NoContent();
        }

        [HttpPost]
        [Route("createplayer")]
        public ActionResult<Player> CreatePlayer(string name, Position position)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            var response = _playerService.AddPlayer(name, position);
            if (response.Success)
                return response.Payload;

            return NoContent();
        }
    }
}
