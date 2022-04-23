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
    public class CategDepenseService : ICategDepense
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public CategDepenseService(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<bool> CreateCatDep(Categoriedepense categdepense)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"insert into categorie_dep(designation) values(@designation)";
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { categdepense.designation }, commandType: System.Data.CommandType.Text);
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

        public async Task<IEnumerable<Categoriedepense>> Getcategdepense()
        {
            IEnumerable<Categoriedepense> catdep;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from categorie_dep";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    catdep = await conn.QueryAsync<Categoriedepense>(query);
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
            return catdep;
        }
        public async Task<IEnumerable<Categoriedepense>> GetMontantDepense()
        {
            IEnumerable<Categoriedepense> Montantdepense;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select sum(montant)tot,count(*)nbr from depenses";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    Montantdepense = await conn.QueryAsync<Categoriedepense>(query);
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
            return Montantdepense;
        }
    }
    }

