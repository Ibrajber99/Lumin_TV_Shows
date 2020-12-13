using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLFactories;
using Models;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Name: Ibrahim Jaber
/// Purpose: Database programming final project
/// Instructor: Andre Boudreau 
/// </summary>

namespace DataAccess
{
    public class SqlTVShow : ITVShowRepo
    {
        public int Create(TVShow show)
        {
            string sqlString = $@"
                    INSERT INTO Show
                    (
                        [ShowName]
                       ,[ReleaseDate]
                       ,[ShowDescription]
                       ,[NumOfSeasons]
                       ,[PDCompanyID]
                       ,[GenreID]
                       ,[RatingID]
                       ,[PlatformID])
                        VALUES 
                    (
                         @title
                        ,@relaseDate
                        ,@showDesc
                        ,@seasons
                        ,@pdcompId
                        ,@genreId
                        ,@ratingId
                        ,@platformId
                    )".Replace(Environment.NewLine, "");

            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@title", show.ShowName);
            cmd.Parameters.AddWithValue("@relaseDate", show.ReleaseDate);
            cmd.Parameters.AddWithValue("@showDesc", show.ShowDescription);
            cmd.Parameters.AddWithValue("@seasons", show.NumOfSeasons);
            cmd.Parameters.AddWithValue("@pdcompId", show.PDCompanyID);
            cmd.Parameters.AddWithValue("@genreId", show.GenreID);
            cmd.Parameters.AddWithValue("@ratingId", show.RatingID);
            cmd.Parameters.AddWithValue("@platformId", show.PlatformID);
            int rowsAffected = DataAccess.DataAccessHelper.ExecuteNonQuery(cmd);

            show.ShowID = GetLastInsertedShowID();
            AddActorsToShow(show);

            return rowsAffected;
        }

        public int Save(TVShow show)
        {
            string sqlString = $@"UPDATE 
                                Show
                                SET ShowName = @showname
                                ,ReleaseDate = @releaseDate
                                ,NumOfSeasons = @numOfSeason
                                ,PDCompanyID = @pdCompanyId
                                ,GenreID = @genreID
                                ,RatingID = @ratingId
                                ,PlatformID = @platformId
                                ,ShowDescription = @showDescription
                                 WHERE ShowID = @showId";

            SqlCommand cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@showname",show.ShowName );
            cmd.Parameters.AddWithValue("@releaseDate", show.ReleaseDate);
            cmd.Parameters.AddWithValue("@numOfSeason", show.NumOfSeasons);
            cmd.Parameters.AddWithValue("@pdCompanyId", show.PDCompanyID);
            cmd.Parameters.AddWithValue("@genreID", show.GenreID);
            cmd.Parameters.AddWithValue("@ratingId", show.RatingID);
            cmd.Parameters.AddWithValue("@platformId", show.PlatformID);
            cmd.Parameters.AddWithValue("@showDescription", show.ShowDescription);
            cmd.Parameters.AddWithValue("@showId", show.ShowID);

            int rowAffected = DataAccess.DataAccessHelper.ExecuteNonQuery(cmd);

            return rowAffected;
        }

        public int Delete(TVShow show)
        {
            string sqlString = "EXEC dbo.DeleteShow @showId";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@showId", show.ShowID);

            int rowsAffected = DataAccess.DataAccessHelper.ExecuteNonQuery(cmd);
            return rowsAffected;
        }

        public void AddActorsToShow(TVShow show)
        {
            string sqlString = "INSERT INTO showToActor VALUES(@showID,@actorID)";
            foreach (Actor actor in show.showCast)
            {
                var cmd = new SqlCommand(sqlString);
                cmd.Parameters.AddWithValue("@showID",show.ShowID);
                cmd.Parameters.AddWithValue("@actorID", actor.ActorID);
                DataAccess.DataAccessHelper.ExecuteNonQuery(cmd);
            }
        }

        public string GetLastInsertedShowID()
        {
            string sqlString = "SELECT TOP 1 ShowID FROM Show ORDER BY ShowID DESC";
            var executedValue = DataAccess.DataAccessHelper.GetValue(new SqlCommand(sqlString));
            string showId = Convert.ToString(executedValue);

            return showId;
        }

        public List<Actor> GetShowCastList(string showID)
        {
            List<Actor> castList = new List<Actor>();

            string sqlString = $@"
                SELECT Actor.ActorID,Actor.FirstName,Actor.MiddleName,Actor.LastName,
                Actor.DateOfBirth,Actor.FullName FROM ShowToActor
                RIGHT JOIN Actor ON Actor.ActorID = ShowToActor.ActorID
                 WHERE ShowToActor.showID IN(SELECT ShowID From show Where showID = @showId)    
                ".Replace(Environment.NewLine, ""); 


            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@showId", showID);

            var dt = DataAccess.DataAccessHelper.GetDataTable(cmd);

            foreach(DataRow dtr in dt.Rows)
            {
                castList.Add(GetActorFromDataRow(dtr));
            }
            return castList;
        }

        public List<TVShow> GetShowsList()
        {
            List<TVShow> tvShowsList = new List<TVShow>();
            string sqlString = "SELECT * FROM Show ORDER BY ShowID";
            var cmd = new SqlCommand(sqlString);

            var dt = DataAccess.DataAccessHelper.GetDataTable(cmd);

            foreach(DataRow dtr in dt.Rows)
            {
                tvShowsList.Add(GetShowFromDataRow(dtr));
            }

            return tvShowsList;
        }

        public DataTable GetShowsTable()
        {
            string sqlString = "SELECT * FROM Show ORDER BY ShowID";
            var cmd = new SqlCommand(sqlString);

            return DataAccess.DataAccessHelper.GetDataTable(cmd); ;
        }

        public TVShow GetShowFromDataRow(DataRow dtr)
        {
            if (dtr != null)
            {
                TVShow tmpTvShow = new TVShow();
                tmpTvShow.ShowID = dtr["ShowID"].ToString();
                tmpTvShow.ShowName = dtr["ShowName"].ToString();
                tmpTvShow.ReleaseDate = Convert.ToDateTime(dtr["ReleaseDate"]);
                tmpTvShow.NumOfSeasons = dtr["NumOfSeasons"].ToString();
                tmpTvShow.PDCompanyID = dtr["PDCompanyID"].ToString();
                tmpTvShow.GenreID = dtr["GenreID"].ToString();
                tmpTvShow.RatingID = dtr["RatingID"].ToString();
                tmpTvShow.PlatformID = dtr["PlatformID"].ToString();
                tmpTvShow.ShowDescription = dtr["ShowDescription"].ToString();
                tmpTvShow.showCast = GetShowCastList(tmpTvShow.ShowID);

                return tmpTvShow;

            }
            return null;
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

        public int RemoveActorFromExistingShow(TVShow show, string actorId)
        {
            string sqlString = "DELETE FROM ShowToActor WHERE ActorID = @actorId AND ShowID=@showID";
            var cmd = new SqlCommand(sqlString);

            cmd.Parameters.AddWithValue("@actorId", actorId);
            cmd.Parameters.AddWithValue("@showID", show.ShowID);

            int rowsAffected = DataAccess.DataAccessHelper.ExecuteNonQuery(cmd);

            return rowsAffected;
        }

        public int AddActorToExistingShow(TVShow show, string actorId)
        {
            string sqlString = "INSERT INTO ShowToActor VALUES(@showID,@actorId)";
            var cmd = new SqlCommand(sqlString);
            cmd.Parameters.AddWithValue("@showID", show.ShowID);
            cmd.Parameters.AddWithValue("@actorId", actorId);

            int rowsAffectred = DataAccess.DataAccessHelper.ExecuteNonQuery(cmd);
            return rowsAffectred;
        }

        async Task<List<TVShow>> ITVShowRepo.GetAsyncTVShowsList()
        {
            List<TVShow> tvShowsList = new List<TVShow>();
            string sqlString = "SELECT * FROM Show ORDER BY ShowID";
            var cmd = new SqlCommand(sqlString);

            var dt = await DataAccess.DataAccessHelper.GetDataAsync(cmd);

            foreach (DataRow dtr in dt.Rows)
            {
                tvShowsList.Add(GetShowFromDataRow(dtr));
            }

            return tvShowsList;
        }
    }
}
