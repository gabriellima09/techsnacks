using TechSnacks.Domain.Core;

namespace TechSnacks.Domain.Repositories
{
    public interface IAggregateRepository<T>
        where T : IAggregateRoot
    { }
}
