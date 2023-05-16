using TechSnacks.Domain.Aggregates;

namespace TechSnacks.Domain.Repositories
{
    public interface IOrderRepository : IAggregateRepository<Order>
    {
        Task Save(Order product);
        Task<Order> Get(Guid id);
        Task<List<Order>> GetAll();
    }
}
