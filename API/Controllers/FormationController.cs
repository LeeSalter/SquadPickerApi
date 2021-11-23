using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SquadPicker.Data;
using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormationController : ControllerBase
    {
        private readonly SquadPickerContext _db;
        public FormationController(SquadPickerContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Formation> Formations()
        {
            return _db.Formations.ToList();
        }

        [Route("api/[controller]/id")]
        [HttpGet]
        public Formation GetById(Guid id)
        {
            return _db.Formations.SingleOrDefault(x => x.Id == id);
        }
    }
}
