using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.classes
{
    public class Recettes
    {
        public int id_rec { get; set; }
        public string motif { get; set; }
        public float montant { get; set; }
        public int id { get; set; }
        public DateTime dates { get; set; }
        public string users { get; set; }
        public string design { get; set; }
    }
}
