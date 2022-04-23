using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
    public interface ICategDepense
    {
        Task<bool> CreateCatDep(Categoriedepense categdepense);
        Task<IEnumerable<Categoriedepense>> Getcategdepense();
        Task<IEnumerable<Categoriedepense>> GetMontantDepense();
    }
}
