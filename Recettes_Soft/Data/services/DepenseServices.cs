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
    public class DepenseServices : IDepense_services
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public DepenseServices(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public async Task<bool> CreateDepense(Depenses depense)
        {
            var parameters = new DynamicParameters();
            parameters.Add("motif", depense.motif, DbType.String);
            parameters.Add("montant", depense.montant, DbType.Int32);
            parameters.Add("id", depense.id, DbType.Int32);
            parameters.Add("beneficiaire", depense.beneficiaire, DbType.Int32);
            parameters.Add("autorisation", depense.autorisation, DbType.String);
            parameters.Add("libelle", depense.libelle, DbType.String);
            parameters.Add("users", depense.users, DbType.String);
            using (var conn = new SqlConnection(_Configuration.value))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync("sp_depenses", parameters, commandType: CommandType.StoredProcedure);
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

        public async Task<bool> EditDepense(int id_dep, Depenses depense)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string req = @"update depenses set motif=@motif,montant=@montant,id=@id,dates=getdate(),beneficiaire=beneficiaire,autorisation=@autorisation,libelle=@libelle,users=@users where id_dep=@id_dep";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(req, new { depense.motif, depense.montant, depense.id, depense.dates, depense.beneficiaire, depense.autorisation,depense.libelle, depense.users, depense.id_dep }, commandType: CommandType.Text);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }

            }
            return true;
        }

        public async Task<IEnumerable<Depenses>> GetDepense()
        {
            IEnumerable<Depenses> depenses;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from aff_dep order by id_dep desc";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    depenses = await conn.QueryAsync<Depenses>(query);
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
            return depenses;
        }

        public async Task<IEnumerable<Depenses>> GetRapportDepenses()
        {
            IEnumerable<Depenses> depenses;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    depenses = await conn.QueryAsync<Depenses>("rapportDepense", commandType: CommandType.StoredProcedure);
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
            return depenses;
        }

        public async Task<Depenses> SingleDepense(int id_dep)
        {
            Depenses depense = new Depenses();
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string req = @"select id_dep,motif,montant,dates,autorisation,libelle,users from aff_dep where id_dep=@id_dep";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    depense = await conn.QueryFirstOrDefaultAsync<Depenses>(req, new { id_dep }, commandType: CommandType.Text);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
            return depense;
        }
    }
}
