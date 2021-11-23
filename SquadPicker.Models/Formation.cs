using System;
using System.Collections.Generic;

namespace SquadPicker.Models
{
    public partial class Formation
    {
        public Formation()
        {
            Teams = new HashSet<Team>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Goalkeepers { get; set; }
        public int Defenders { get; set; }
        public int Midfielders { get; set; }
        public int Forwards { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
