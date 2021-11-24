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
    public class FormationController : ControllerBase
    {
        private readonly IFormationService _formationService;
        public FormationController(IFormationService formationService)
        {
            _formationService = formationService;
        }

        [HttpGet]
        public ActionResult<List<Formation>> Formations()
        {
            var response = _formationService.GetFormations();
            if (response.Success && response.Payload!=null)
                return response.Payload;

            return NoContent();
        }

        [Route("api/[controller]/id")]
        [HttpGet]
        public ActionResult<Formation> GetById(Guid id)
        {
            var response = _formationService.GetFormation(id);
            if (response.Success)
                return response.Payload;

            return NoContent();
        }
    }
}
