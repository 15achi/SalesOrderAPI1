using SalesOrderAPI1.Entity;

namespace SalesOrderAPI1.Container
{
    public interface IMasterContainer
    {
        Task<List<VariantEntity>> GetAllVariant(string variantType);
        Task<List<CategoryEntity>> GetCategory();
    }
}
