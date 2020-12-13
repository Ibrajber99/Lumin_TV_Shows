using Models;
using SQLFactories;
using System;
using System.Data.SqlClient;

/// <summary>
/// Name: Ibrahim Jaber
/// Purpose: Database programming final project
/// Instructor: Andre Boudreau 
/// </summary>

namespace DataAccess
{
    public class SqlUser : IUserRepo
    {
        public int Create(User user)
        {
            if (GetUser(user) == 0)
            {
                string sqlString = $@"
                    INSERT INTO UserLogin
                    (
                        [UserName]
                       ,[UserPassword])
                        VALUES 
                    (
                         @username
                        ,@passwrd
                    )".Replace(Environment.NewLine, "");

                var cmd = new SqlCommand(sqlString);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@passwrd", user.Userpassword);

                int rowsAffectred = DataAccessHelper.ExecuteNonQuery(cmd);

                return rowsAffectred;
            }
            else
            {
                return -1;
            }
        }

        public int GetUser(User user)
        {
            string sqlString =
                $@"SELECT COUNT(*) FROM UserLogin 
                    WHERE UserPassword = @passwrd
                    AND UserName =@username"
                    .Replace(Environment.NewLine, "");

            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@username", user.UserName);
            cmd.Parameters.AddWithValue("@passwrd", user.Userpassword);

            var valueExecuted = DataAccess.DataAccessHelper.GetValue(cmd);
            return Convert.ToInt32(valueExecuted);
        }
    }
}
