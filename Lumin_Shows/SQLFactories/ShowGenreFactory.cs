using System;

namespace SQLFactories
{
    public class ShowGenreFactory
    {
        public static Func<IShowGenre> ShowGenreRepoFunc { private get; set; }

        public static IShowGenre CreateShowGenreRepo()
        {
            return ShowGenreRepoFunc();
        }
    }
}
