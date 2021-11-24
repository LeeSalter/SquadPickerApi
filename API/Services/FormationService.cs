using API.Models;
using SquadPicker.Data;
using SquadPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class FormationService:IFormationService
    {
        private readonly SquadPickerContext _db;
        public FormationService(SquadPickerContext db)
        {
            _db = db;
        }

        public DbResponse<List<Formation>> GetFormations()
        {
            var formations = _db.Formations.ToList();
            if (formations != null)
                return new DbResponse<List<Formation>>(true, string.Empty, formations);

            return new DbResponse<List<Formation>>(true, string.Empty, null);
        }

        public DbResponse<Formation>GetFormation(Guid id)
        {
            var formation = _db.Formations.Find(id);
            if (formation != null)
                return new DbResponse<Formation>(true, string.Empty, formation);

            return new DbResponse<Formation>(false, "Formation not found", null);
        }
    }

    public interface IFormationService
    {
        DbResponse<List<Formation>> GetFormations();
        DbResponse<Formation> GetFormation(Guid id);
    }
}
