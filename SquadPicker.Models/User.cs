using System;
using System.Collections.Generic;

namespace SquadPicker.Models
{
    public partial class User
    {
        public User()
        {
            Teams = new HashSet<Team>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
