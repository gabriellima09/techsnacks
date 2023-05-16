using TechSnacks.Domain.Core;

namespace TechSnacks.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public Product(string name, string description, decimal price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
