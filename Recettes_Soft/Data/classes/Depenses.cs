using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.classes
{
    public class Depenses
    {
        public int id_dep { get; set; }
        public string motif { get; set; }
        public float montant { get; set; }
        public int id { get; set; }
        public DateTime dates { get; set; }
        public int beneficiaire { get; set; }
        public string autorisation { get; set; }
        public string libelle { get; set; }
        public string users { get; set; }
        public string noms { get; set; }
        public string designation { get; set; }
        
    }
}
