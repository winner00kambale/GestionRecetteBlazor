using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
    public interface IRecettes_services
    {
        Task<IEnumerable<Recettes>> GetRecettes();
        Task<IEnumerable<Recettes>> GetRapportRecettes();
        Task<bool> CreateRecette(Recettes recette);
        Task<bool> EditRecette(int id_rec, Recettes recette);
        Task<Recettes> SingleRecette(int id_rec);
    }
}
