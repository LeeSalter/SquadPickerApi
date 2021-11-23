using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SquadPicker.Models
{
    public class Player
    {
        public Player()
        {
            TeamPlayer = new HashSet<TeamPlayer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public bool Selected { get; set; }
        public string Availability { get; set; }
        public string Validity { get; set; }
        public Guid? TeamId { get; set; }

        public virtual Team Team { get; set; }
        public virtual ICollection<TeamPlayer> TeamPlayer { get; set; }
    }
}