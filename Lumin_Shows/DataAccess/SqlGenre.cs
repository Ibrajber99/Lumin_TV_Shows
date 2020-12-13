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
    public class SqlGenre : IShowGenre
    {
        public string GetGenreName(string genreID)
        {
            string sqlString = "SELECT GenreName FROM Genre WHERE GenreID = @genreId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@genreId", genreID);

            var executedValue = DataAccess.DataAccessHelper.GetValue(cmd);

            return Convert.ToString(executedValue);

        }

        public DataTable GetGenres()
        {
            string sqlString = "SELECT * FROM Genre";

            return DataAccess.DataAccessHelper.
                GetDataTable(new SqlCommand(sqlString));
        }
    }
}
