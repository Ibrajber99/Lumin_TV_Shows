using Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SQLFactories
{
    public interface IProductionCompanyRepo
    {
        int Create(ProductionCompany pdComp);

        int Save(ProductionCompany pdComp);

        int Delete(ProductionCompany pdComp);

        List<ProductionCompany> GetProductionCompanies();

        DataTable GetProductionCompaniesTable();

        int GetCountAssociatedShows(string PDcompID);

        ProductionCompany GetProductionCompanyByID(string pdCompId);

        List<TVShow> GetProducedShows(string pdCompId);

        TVShow GetTVShowFromDataRow(DataRow dtr);

        Task<List<ProductionCompany>> GetAsyncProdCompanies(); 
    }
}
