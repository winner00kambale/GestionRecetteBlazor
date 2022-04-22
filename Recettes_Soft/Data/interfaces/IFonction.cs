using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
     public interface IFonction
    {
        Task<bool> CreateFonction(Fonctions fonction);
        Task<IEnumerable<Fonctions>> Getfonction();
    }
}
