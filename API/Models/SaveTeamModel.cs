using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class SaveTeamModel
    {
        public Guid FormationId { get; set; }
        public List<int> PlayerIds { get; set; }
    }
}
