using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CreatePlayerModel
    {
        public string PlayerName { get; set; }
        public Position Position { get; set; }
    }
}
