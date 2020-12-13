using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

/// <summary>
/// Name: Ibrahim Jaber
/// Purpose: Database programming final project
/// Instructor: Andre Boudreau 
/// </summary>

namespace DataAccess
{
    public static class DataAccessHelper
    {
        public static string connectionString { private get; set; }

        /// <summary>
        /// Queries a SQL Server database with a provided SELECT statement.
        /// </summary>
        /// <param name="sql">The SELECT SQL Statement to execute and query data</param>
        /// <returns>DataTable containing results from the provided SQL statement</returns>
        internal static DataTable GetDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }

        internal static object GetValue(SqlCommand cmd)
        {
            object returnValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;

                conn.Open();
                returnValue = cmd.ExecuteScalar();
                
            }

            return returnValue;
        }

        internal static int ExecuteNonQuery(SqlCommand cmd)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;

                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return rowsAffected;
        }

        internal static async Task<DataTable> GetDataAsync(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.Connection = conn;

                    conn.Open();
                    await Task.Run(() => da.Fill(dt));
                    conn.Close();
                }
            }

            return dt;
        }
    }
}
