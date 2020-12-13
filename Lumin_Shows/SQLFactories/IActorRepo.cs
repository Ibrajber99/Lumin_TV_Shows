using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Models;

namespace SQLFactories
{
    public interface IActorRepo
    {
        int Create(Actor actor);

        int Delete(Actor actor);

        int Save(Actor actor);

        List<Actor> GetActorsList();

        DataTable GetActorsTable();

        int GetCountActorPlayedShows(string actorID);

        TVShow GetShowFromDataRow(DataRow dtr);

        List<TVShow> GetActorPlayedShows(string actoIrD);

        Task<List<Actor>> GetAsyncActorList();

    }
}
