using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class TeamModel
    {
        public Guid UserId { get; set; }
        public Guid FormationId { get; set; }
        public List<int> PlayerIds { get; set; }
    }
}
