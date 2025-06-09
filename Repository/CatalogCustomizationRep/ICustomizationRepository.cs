using Saas.Models;


namespace Saas.Repository.CatalogCustomizationRep
{
    public interface ICustomizationRepository
    {
        Task<CatalogCustomization?> GetByCatalogIdAsync(int catalogId);
        Task AddAsync(CatalogCustomization customization);
        Task UpdateAsync(CatalogCustomization customization);
        Task SaveChangesAsync();
    }
}
