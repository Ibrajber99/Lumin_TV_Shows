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
    public class SqlStreamingPlatform : IStreamingPlatform
    {
        public string GetStreamingPlatformName(string platformId)
        {
            string sqlString = "SELECT PlatformName FROM StreamingPlatform WHERE PlatformID = @platformId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@platformId", platformId);

            var executedValue = DataAccess.DataAccessHelper.GetValue(cmd);

            return Convert.ToString(executedValue);
        }

        public DataTable GetStreamingPlatforms()
        {
            string sqlString = "SELECT * FROM StreamingPlatform";

            return DataAccess.DataAccessHelper.
                GetDataTable(new SqlCommand(sqlString));
        }
    }
}
