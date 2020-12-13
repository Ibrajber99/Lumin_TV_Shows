using System;
using System.Collections.Generic;

namespace Models
{
    public class TVShow
    {
        public string ShowID { get; set; }
        public string ShowName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ShowDescription { get; set; }
        public string NumOfSeasons { get; set; }
        public string PDCompanyID { get; set; }
        public string GenreID { get; set; }
        public string RatingID { get; set; }
        public string PlatformID { get; set; }
        public List<Actor> showCast;

        public TVShow()
        {
            showCast = new List<Actor>();
        }

    }
}
