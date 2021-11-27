using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class LoadTeamModel
    {
        public Formation Formation { get; set; }
        public List<Player> Players { get; set; }
    }
}
