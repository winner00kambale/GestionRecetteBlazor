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
    public class CategRecetteService : ICategRecette
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public CategRecetteService(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<bool> CreateCatRec(CategorieRecette categrecette)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"insert into categorie_rec(designation) values(@designation)";
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { categrecette.designation }, commandType: System.Data.CommandType.Text);
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

        public async Task<IEnumerable<CategorieRecette>> Getcategrecette()
        {
            IEnumerable<CategorieRecette> catrec;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from categorie_rec";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    catrec = await conn.QueryAsync<CategorieRecette>(query);
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
            return catrec;
        }
    }
}
