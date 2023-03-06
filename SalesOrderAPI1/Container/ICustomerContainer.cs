using SalesOrderAPI1.Entity;

namespace SalesOrderAPI1.Container
{
    public interface ICustomerContainer
    {
        Task<List<CustomerEntity>> Getall();
        Task<CustomerEntity> Getbycode(string code);
    }
}
