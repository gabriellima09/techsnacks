using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSnacks.Domain.Aggregates;

namespace TechSnacks.Domain.Repositories
{
    public interface ICustomerRepository : IAggregateRepository<Customer>
    {
        Task<Customer> GetById(Guid id);
        Task<Customer> GetByPhone(string phoneNumber);
        Task Save(Customer customer);
    }
}
