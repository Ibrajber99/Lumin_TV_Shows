using Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SQLFactories
{
    public interface ITVShowRepo
    {
        int Create(TVShow show);

        int Save(TVShow show);

        void AddActorsToShow(TVShow show);

        List<Actor> GetShowCastList(string showID);

        List<TVShow> GetShowsList();

        DataTable GetShowsTable();

        string GetLastInsertedShowID();

        Actor GetActorFromDataRow(DataRow dtr);

        int RemoveActorFromExistingShow(TVShow show, string actorId);

        int AddActorToExistingShow(TVShow show, string actorId);

        int Delete(TVShow show);

        Task<List<TVShow>> GetAsyncTVShowsList();
        

    }
}
