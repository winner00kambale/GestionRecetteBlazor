using Recettes_Soft.Data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.interfaces
{
    public interface IBeneficiaire
    {
        Task<IEnumerable<Beneficiaire>> GetBeneficiaire();
        Task<bool> CreateBeneficiaire(Beneficiaire beneficiare);
        Task<bool> EditBeneficiaire(int code, Beneficiaire beneficiare);
        Task<Beneficiaire> SingleBeneficiaire(int code);
    }
}
