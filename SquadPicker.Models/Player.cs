using System;
using System.Collections.Generic;

namespace SquadPicker.Models
{
    public partial class Player
    {
        public Player()
        {
            TeamPlayers = new HashSet<TeamPlayer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public bool Selected { get; set; }
        public string Availability { get; set; }
        public string Validity { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}
