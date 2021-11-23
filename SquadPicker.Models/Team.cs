using System;
using System.Collections.Generic;

namespace SquadPicker.Models
{
    public partial class Team
    {
        public Team()
        {
            TeamPlayers = new HashSet<TeamPlayer>();
        }

        public Guid Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public Guid? FormationId { get; set; }
        public Guid? UserId { get; set; }

        public virtual Formation Formation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}
