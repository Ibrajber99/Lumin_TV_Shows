using System;

namespace SQLFactories
{
    public class ShowRatingFactory
    {
        public static Func<IShowRating> ShowRatingRepoFunc { private get; set; }

        public static IShowRating CreateShowRatingRepo()
        {
            return ShowRatingRepoFunc();
        }

    }
}
