using TechSnacks.Domain.Core;
using TechSnacks.Domain.Entities;
using TechSnacks.Domain.Enums;
using TechSnacks.Domain.ValueObjects;

namespace TechSnacks.Domain.Aggregates
{
    public class Order : Entity, IAggregateRoot
    {
        public Order(Guid customerId)
        {
            CustomerId = customerId;
            Date = DateTimeOffset.Now;
        }

        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();
        private readonly List<OrderItem> _items = new();

        public Guid CustomerId { get; private set; }
        public Address DeliveryAddress { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public DateTimeOffset Date { get; private set; }

        public int TotalItems => Items.Sum(x => x.Quantity);
        public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);

        public void AddItem(Guid productId, decimal price, int quantity = 1)
        {
            if(Items.Any(x => x.ProductId == productId))
            {
                var existentItem = Items.First(x => x.ProductId == productId);
                existentItem.AddQuantity(quantity);
                return;
            }

            _items.Add(new OrderItem(productId, price, quantity));
        }

        public void SetDeliveryAddress(Address deliveryAddress)
        {
            DeliveryAddress = deliveryAddress ?? throw new ArgumentNullException(nameof(deliveryAddress));
        }

        public void SetPaymentMethod(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
    }
}
