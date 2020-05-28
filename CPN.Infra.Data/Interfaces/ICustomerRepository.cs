using CPN.Model;

namespace CPN.Infra.Data.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetById(long id);
        Customer GetByName(string name);
    }
}
