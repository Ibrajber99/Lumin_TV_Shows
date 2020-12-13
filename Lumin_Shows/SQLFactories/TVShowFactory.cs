using System;

namespace SQLFactories
{
    public class TVShowFactory
    {
        public static Func<ITVShowRepo> TVShowRepoFunc { private get; set; }

        public static ITVShowRepo CreateTVShowRepo()
        {
            return TVShowRepoFunc();
        }
    }
}
