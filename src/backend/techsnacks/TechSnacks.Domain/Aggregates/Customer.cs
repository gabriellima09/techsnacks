using TechSnacks.Domain.Core;
using TechSnacks.Domain.ValueObjects;

namespace TechSnacks.Domain.Aggregates
{
    public class Customer : Entity, IAggregateRoot
    {
        public Customer(string name, List<Address> addresses, Phone phone)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
        }

        public IReadOnlyCollection<Address> Addresses => _addresses.AsReadOnly();
        private readonly List<Address> _addresses = new();

        public string Name { get; private set; }
        public Phone Phone { get; set; }
    }
}
