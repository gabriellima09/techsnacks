using TechSnacks.Domain.Core;
using TechSnacks.Domain.ValueObjects;

namespace TechSnacks.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, List<Address> addresses, Phone phone)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Addresses = addresses ?? throw new ArgumentNullException(nameof(addresses));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
        }

        public string Name { get; private set; }
        public List<Address> Addresses { get; set; }
        public Phone Phone { get; set; }
    }
}
