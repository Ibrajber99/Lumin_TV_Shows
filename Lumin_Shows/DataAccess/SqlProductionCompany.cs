
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Models;
using SQLFactories;

/// <summary>
/// Name: Ibrahim Jaber
/// Purpose: Database programming final project
/// Instructor: Andre Boudreau 
/// </summary>

namespace DataAccess
{
    public class SqlProductionCompany : IProductionCompanyRepo
    {
        public int Create(ProductionCompany pdComp)
        {
            string sqlString = "INSERT INTO ProductionCompany VALUES(@pdCompName,@pdDescription)";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@pdCompName", pdComp.PDCompanyName);
            cmd.Parameters.AddWithValue("@pdDescription", pdComp.Description);

            int rowsAffected = DataAccessHelper.ExecuteNonQuery(cmd);
            return rowsAffected;

        }

        public int Delete(ProductionCompany pdComp)
        {
            if (GetCountAssociatedShows(pdComp.PDCompanyID) < 1)
            {
                string sqlString = "DELETE FROM ProductionCompany WHERE PDCompanyID = @pdCompID";
                var cmd = new SqlCommand(sqlString);
                cmd.Parameters.AddWithValue("@pdCompID", pdComp.PDCompanyID);

                int rowsAffected = DataAccessHelper.ExecuteNonQuery(cmd);
                return rowsAffected;
            }
            else
            {
                return -1;
            }
           
        }

        public int Save(ProductionCompany pdComp)
        {
            string sqlString = "UPDATE ProductionCompany SET " +
                "PDCompanyName=@pdCompName, Description=@description WHERE PDCompanyID = @pdCompId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@pdCompName", pdComp.PDCompanyName);
            cmd.Parameters.AddWithValue("@description", pdComp.Description);
            cmd.Parameters.AddWithValue("@pdCompId", pdComp.PDCompanyID);

            int rowsAffected = DataAccessHelper.ExecuteNonQuery(cmd);
            return rowsAffected;

        }

        public DataTable GetProductionCompaniesTable()
        {
            string sqlString = "SELECT * FROM ProductionCompany";

            return DataAccess.DataAccessHelper.GetDataTable(new SqlCommand(sqlString));
        }

        public List<ProductionCompany> GetProductionCompanies()
        {
            List<ProductionCompany> ProdCompaniesList = new List<ProductionCompany>();
            var dt =DataAccessHelper.GetDataTable(new SqlCommand("SELECT * FROM ProductionCompany"));

            foreach(DataRow dtr in dt.Rows)
            {
                ProdCompaniesList.Add
                    (GetProductionCompanyFromDataRow(dtr));
            }

            return ProdCompaniesList;
        }

        public ProductionCompany GetProductionCompanyByID(string pdCompId)
        {
            string sqlString = "SELECT * FROM ProductionCompany WHERE PDCompanyID = @pdCompId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@pdCompId", pdCompId);

            var dt = DataAccess.DataAccessHelper.GetDataTable(cmd);
            return GetProductionCompanyFromDataRow(dt.Rows[0]);
        }

        public ProductionCompany GetProductionCompanyFromDataRow(DataRow dtr)
        {
            if(dtr != null)
            {
                ProductionCompany prodCompResult = new ProductionCompany();
                prodCompResult.PDCompanyID = dtr["PDCompanyID"].ToString();
                prodCompResult.PDCompanyName = dtr["PDCompanyName"].ToString();
                prodCompResult.Description = dtr["Description"].ToString();
                return prodCompResult;
            }

            return null;
            
        }

        public int GetCountAssociatedShows(string PDcompID)
        {
            string sqlString = "SELECT COUNT(*) FROM Show WHERE PDCompanyID =@pdCompanyId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@pdCompanyId", PDcompID);

            var executedValue = DataAccess.DataAccessHelper.GetValue(cmd);

            return Convert.ToInt32(executedValue);
        }

        List<TVShow> IProductionCompanyRepo.GetProducedShows(string pdCompId)
        {
            List<TVShow> producedShowsList = new List<TVShow>();

            string sqlString =
                "SELECT Show.ShowID,Show.ShowName FROM Show WHERE PDCompanyID =@pdCompanyId";

            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@pdCompanyId", pdCompId);

            var dt = DataAccessHelper.GetDataTable(cmd);
            foreach (DataRow dtr in dt.Rows)
            {
                producedShowsList.Add(GetTVShowFromDataRow(dtr));
            }

            return producedShowsList;
        }

        public TVShow GetTVShowFromDataRow(DataRow dtr)
        {
            if (dtr != null)
            {
                TVShow tmpTvShow = new TVShow();
                tmpTvShow.ShowID = dtr["ShowID"].ToString();
                tmpTvShow.ShowName = dtr["ShowName"].ToString();
                return tmpTvShow;

            }
            return null;
        }

        async Task<List<ProductionCompany>> IProductionCompanyRepo.GetAsyncProdCompanies()
        {
            List<ProductionCompany> ProdCompaniesList = new List<ProductionCompany>();
            var dt = await DataAccessHelper.GetDataAsync(new SqlCommand("SELECT * FROM ProductionCompany"));

            foreach (DataRow dtr in dt.Rows)
            {
                ProdCompaniesList.Add
                    (GetProductionCompanyFromDataRow(dtr));
            }

            return ProdCompaniesList;
        }
    }
}
