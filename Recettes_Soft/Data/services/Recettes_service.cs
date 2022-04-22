using Recettes_Soft.Data.classes;
using Recettes_Soft.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Recettes_Soft.Data;
using System.Data;

namespace Recettes_Soft.Data.services
{
    public class Recettes_service : IRecettes_services
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public Recettes_service(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<bool> CreateRecette(Recettes recette)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"insert into recettes(motif,montant,dates,id,users)values(@motif,@montant,getdate(),@id,@users)";
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { recette.motif, recette.montant, recette.dates, recette.id, recette.users }, commandType: System.Data.CommandType.Text);
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
            //var parameters = new DynamicParameters();
            //parameters.Add("motif", recette.motif, DbType.String);
            //parameters.Add("montant", recette.montant, DbType.Int32);
            //parameters.Add("dates", recette.dates, DbType.DateTime);
            //parameters.Add("id", recette.id, DbType.Int32);
            //parameters.Add("users", recette.users, DbType.String);
            //using (var conn = new SqlConnection(_Configuration.value))
            //{              
            //    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            //    try
            //    {
            //        await conn.ExecuteAsync("sp_recette", parameters, commandType: CommandType.StoredProcedure);
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //    finally
            //    {
            //        if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            //    }
            //}
            //return true;
        }

        public async Task<bool> EditRecette(int id_rec, Recettes recette)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string req = @"update recettes set motif=@motif,montant=@montant,dates=getdate(),id=@id,users=@users where id_rec=@id_rec";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(req, new { recette.motif, recette.montant, recette.dates, recette.id, recette.users,recette.id_rec }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<Recettes>> GetRapportRecettes()
        {
            IEnumerable<Recettes> recette;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    recette = await conn.QueryAsync<Recettes>("rapportRec", commandType: CommandType.StoredProcedure);
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
            return recette;
        }

        public async Task<IEnumerable<Recettes>> GetRecettes()
        {
            IEnumerable<Recettes> recettes;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from aff_rec order by id_rec desc";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    recettes = await conn.QueryAsync<Recettes>(query);
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
            return recettes;
        }

        public async Task<Recettes> SingleRecette(int id_rec)
        {
            Recettes rec = new Recettes();
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string req = @"select id_rec,motif,montant,dates,users from recettes where id_rec=@id_rec";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    rec = await conn.QueryFirstOrDefaultAsync<Recettes>(req, new { id_rec }, commandType: CommandType.Text);
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
            return rec;
        }
    }
}
