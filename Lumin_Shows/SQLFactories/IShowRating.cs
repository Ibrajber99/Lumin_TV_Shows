using System.Data;

namespace SQLFactories
{
    public interface IShowRating
    {
        DataTable GetRatings();

        string GetRatingDescription(string ratingID);
    }
}
