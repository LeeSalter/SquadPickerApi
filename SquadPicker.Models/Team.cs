using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SquadPicker.Models
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
            TeamPlayer = new HashSet<TeamPlayer>();
        }

        public Guid Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public Guid? FormationId { get; set; }
        public Guid? UserId { get; set; }

        public virtual Formation Formation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<TeamPlayer> TeamPlayer { get; set; }
    }
}