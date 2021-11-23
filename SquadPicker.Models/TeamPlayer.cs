using System;
using System.Collections.Generic;

namespace SquadPicker.Models
{
    public partial class TeamPlayer
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
