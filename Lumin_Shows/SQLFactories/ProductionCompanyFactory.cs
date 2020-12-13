using System;


namespace SQLFactories
{
    public class ProductionCompanyFactory
    {
        public static Func<IProductionCompanyRepo> ProductionCompanyRepoFunc { private get; set; }

        public static IProductionCompanyRepo CreateProductionCompanyRepo()
        {
            return ProductionCompanyRepoFunc();
        }

    }
}
