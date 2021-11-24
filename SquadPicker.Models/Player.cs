using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquadPicker.Models
{
    public partial class Player
    {
        public Player()
        {
            TeamPlayers = new HashSet<TeamPlayer>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Position Position { get; set; }
        public bool Selected { get; set; }
        public string Availability { get; set; }
        public string Validity { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<TeamPlayer> TeamPlayers { get; set; }
        public virtual User User { get; set; }
    }
}
