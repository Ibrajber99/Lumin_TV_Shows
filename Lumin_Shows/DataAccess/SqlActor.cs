using Models;
using SQLFactories;
using System;
using System.Collections.Generic;
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
    public class SqlActor : IActorRepo
    {
        public int Create(Actor actor)
        {
            string sqlString = $@"
                    INSERT INTO Actor
                    (
                        [FirstName]
                       ,[MiddleName]
                       ,[LastName]
                       ,[DateOfBirth])
                        VALUES 
                    (
                         @fName
                        ,@mName
                        ,@lName
                        ,@dob
                    )".Replace(Environment.NewLine, "");

            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@fName",actor.FirstName);
            cmd.Parameters.AddWithValue("@mName",actor.MiddleName);
            cmd.Parameters.AddWithValue("@lName",actor.LastName);
            cmd.Parameters.AddWithValue("@dob",actor.DateOfBirth);

            int rowsAffected = DataAccessHelper.ExecuteNonQuery(cmd);

            return rowsAffected;

        }

        public int Delete(Actor actor)
        {
            if (GetCountActorPlayedShows(actor.ActorID) < 1)
            {
                string sqlString = "EXEC dbo.DeleteActor @actorId";
                var cmd = new SqlCommand(sqlString);
                cmd.Parameters.AddWithValue("@actorId", actor.ActorID);

                int rowsAffected = DataAccessHelper.ExecuteNonQuery(cmd);
                return rowsAffected;
            }
            else
            {
                return -1;
            }
        }

        public int Save(Actor actor)
        {
            string sqlString = $@"UPDATE 
                                Actor
                                SET FirstName = @fName
                                ,MiddleName = @mName
                                ,LastName = @lName
                                ,DateOfBirth = @dob
                                 WHERE ActorID = @actorId";

            SqlCommand cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@fName", actor.FirstName);
            cmd.Parameters.AddWithValue("@mName", actor.MiddleName);
            cmd.Parameters.AddWithValue("@lName", actor.LastName);
            cmd.Parameters.AddWithValue("@dob", actor.DateOfBirth);
            cmd.Parameters.AddWithValue("@actorId", actor.ActorID);

            int rowAffected = DataAccessHelper.ExecuteNonQuery(cmd);

            return rowAffected;
        }

        public List<Actor> GetActorsList()
        {
            List<Actor> ActorsList = new List<Actor>();
            var dt = DataAccessHelper.GetDataTable(new SqlCommand("SELECT * FROM Actor"));

            foreach (DataRow dtr in dt.Rows)
            {
                ActorsList.Add(GetActorFromDataRow(dtr));
            }

            return ActorsList;
        }

        public DataTable GetActorsTable()
        {
            string sqlString = "SELECT * FROM Actor";

            return DataAccess.DataAccessHelper.
                GetDataTable(new SqlCommand(sqlString));
        }

        public Actor GetActorFromDataRow(DataRow dtr)
        {
            if (dtr != null)
            {
                Actor actorResult = new Actor();

                actorResult.ActorID = dtr["ActorID"].ToString();
                actorResult.FirstName = dtr["FirstName"].ToString();
                actorResult.MiddleName = dtr["MiddleName"].ToString();
                actorResult.LastName = dtr["LastName"].ToString();
                actorResult.DateOfBirth = Convert.ToDateTime(dtr["DateOfBirth"]);
                actorResult.FullName = dtr["FullName"].ToString();
                return actorResult;
            }
            return null;
        }

        public int GetCountActorPlayedShows(string actorID)
        {
            string sqlString = "EXEC dbo.CountActorPlayedShows @actorId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@actorId", actorID);

            var valueExecuted = DataAccess.DataAccessHelper.GetValue(cmd);

            return Convert.ToInt32(valueExecuted);
        }

        public TVShow GetShowFromDataRow(DataRow dtr)
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

        public List<TVShow> GetActorPlayedShows(string actorID)
        {
            List<TVShow> starredShowsList = new List<TVShow>();

            string sqlString = "EXEC dbo.GetActorPlayedShows @actorId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@actorId", actorID);

            var dt = DataAccessHelper.GetDataTable(cmd);
            foreach(DataRow dtr in dt.Rows)
            {
                starredShowsList.Add(GetShowFromDataRow(dtr));
            }

            return starredShowsList;
        }

        async Task<List<Actor>> IActorRepo.GetAsyncActorList()
        {
            List<Actor> ActorsList = new List<Actor>();
            var dt = await DataAccessHelper.GetDataAsync(new SqlCommand("SELECT * FROM Actor"));

            foreach (DataRow dtr in dt.Rows)
            {
                ActorsList.Add(GetActorFromDataRow(dtr));
            }

            return ActorsList;
        }
    }
}
