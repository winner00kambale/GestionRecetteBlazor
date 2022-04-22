using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
    public interface ICategRecette
    {
        Task<bool> CreateCatRec(CategorieRecette categrecette);
        Task<IEnumerable<CategorieRecette>> Getcategrecette();
    }
}
