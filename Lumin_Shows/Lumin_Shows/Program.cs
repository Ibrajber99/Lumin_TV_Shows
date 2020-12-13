using DataAccess;
using SQLFactories;
using System;
using System.Windows.Forms;
using CM = System.Configuration.ConfigurationManager;


namespace Lumin_Shows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DataAccess.DataAccessHelper.connectionString = 
                CM.ConnectionStrings["LuminShowsDB"].ConnectionString;

            ProductionCompanyFactory.ProductionCompanyRepoFunc = (() => new SqlProductionCompany());
            ActorFactory.ActorRepoFunc = (() => new SqlActor());
            ShowGenreFactory.ShowGenreRepoFunc = (() => new SqlGenre());
            ShowRatingFactory.ShowRatingRepoFunc = (() => new SqlRating());
            StreamingPlatformFactory.StreamingPlatformRepoFunc = (() => new SqlStreamingPlatform());
            TVShowFactory.TVShowRepoFunc = (() => new SqlTVShow());
            UserFactory.UserRepoFunc = (() => new SqlUser());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
