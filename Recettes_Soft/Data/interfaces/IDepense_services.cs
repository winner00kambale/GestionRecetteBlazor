using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
    public interface IDepense_services
    {

        Task<IEnumerable<Depenses>> GetDepense();
        Task<IEnumerable<Depenses>> GetRapportDepenses();
        Task<bool> CreateDepense(Depenses depense);
        Task<bool> EditDepense(int id_dep, Depenses depense);
        Task<Depenses> SingleDepense(int id_dep);
    }
}
