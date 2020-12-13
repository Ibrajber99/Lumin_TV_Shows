using System.Data;

namespace SQLFactories
{
    public interface IShowGenre
    {
        DataTable GetGenres();

        string GetGenreName(string genreID);
    }
}
