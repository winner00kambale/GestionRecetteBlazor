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
    public class Beneficiares_Services : IBeneficiaire
    {
        private readonly SqlConnectionConfiguration _Configuration;
        public Beneficiares_Services(SqlConnectionConfiguration configuration)
        {
            _Configuration = configuration;
        }
        public async Task<bool> CreateBeneficiaire(Beneficiaire beneficiare)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"insert into beneficiares(nom,postnom,sexe,residence,tel,id)values(@nom,@postnom,@sexe,@residence,@tel,@id)";
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(query, new { beneficiare.nom, beneficiare.postnom, beneficiare.sexe, beneficiare.residence, beneficiare.tel, beneficiare.id }, commandType: System.Data.CommandType.Text);
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

        public async Task<bool> EditBeneficiaire(int code, Beneficiaire beneficiare)
        {
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string req = @"update beneficiares set nom=@nom,postnom=@postnom,sexe=@sexe,residence=@residence,id=@id,tel=@tel where code=@code";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    await conn.ExecuteAsync(req, new { beneficiare.nom, beneficiare.postnom, beneficiare.sexe, beneficiare.residence, beneficiare.tel, beneficiare.id, beneficiare.code }, commandType: CommandType.Text);
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

        public async Task<IEnumerable<Beneficiaire>> GetBeneficiaire()
        {
            IEnumerable<Beneficiaire> beneficiaire;
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string query = @"select * from aff_ben order by code desc";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    beneficiaire = await conn.QueryAsync<Beneficiaire>(query);
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
            return beneficiaire;
        }

        public async Task<Beneficiaire> SingleBeneficiaire(int code)
        {
            Beneficiaire beneficiaire = new Beneficiaire();
            using (var conn = new SqlConnection(_Configuration.value))
            {
                const string req = @"select code,nom,postnom,sexe,tel,residence from beneficiares where code=@code";
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    beneficiaire = await conn.QueryFirstOrDefaultAsync<Beneficiaire>(req, new { code }, commandType: CommandType.Text);
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
            return beneficiaire;
        }
    }
}
