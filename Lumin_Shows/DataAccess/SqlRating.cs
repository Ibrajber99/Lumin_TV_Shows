using System;
using System.Data;
using System.Data.SqlClient;
using SQLFactories;

/// <summary>
/// Name: Ibrahim Jaber
/// Purpose: Database programming final project
/// Instructor: Andre Boudreau 
/// </summary>

namespace DataAccess
{
    public class SqlRating : IShowRating
    {
        public string GetRatingDescription(string ratingID)
        {
            string sqlString = "SELECT RatingDescription FROM Rating WHERE RatingID = @ratingId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@ratingId", ratingID);

            var executedValue = DataAccess.DataAccessHelper.GetValue(cmd);

            return Convert.ToString(executedValue);
        }

        public DataTable GetRatings()
        {
            string sqlString = "SELECT * FROM Rating";

            return DataAccess.DataAccessHelper.
                GetDataTable(new SqlCommand(sqlString));
        }
    }
}
