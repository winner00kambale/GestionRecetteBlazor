using Dapper;
using Microsoft.Data.SqlClient;
using Recettes_Soft.Data.classes;
using Recettes_Soft.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.services
{
    public class FonctionService : IFonction
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public FonctionService(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<bool> CreateFonction(Fonctions fonction)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"insert into fonctions(design)values(@design)";
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { fonction.design }, commandType: System.Data.CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open) conn.Close();
                }
            }
            return true;
        }

        public async Task<IEnumerable<Fonctions>> Getfonction()
        {
            IEnumerable<Fonctions> fonc;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from fonctions";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    fonc = await conn.QueryAsync<Fonctions>(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return fonc;
        }
    }
}
