using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data
{
    public class SqlConnectionConfiguration
    {
        public string value { get; }
        public SqlConnectionConfiguration(string value) => this.value = value;
    }
}
