using TechSnacks.Domain.Entities;

namespace TechSnacks.Domain.Repositories
{
    public interface IProductRepository : IAggregateRepository<Product>
    {
        Task Save(Product product);
        Task<Product> Get(Guid id);
        Task<List<Product>> GetAll();
    }
}
