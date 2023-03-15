using TechSnacks.Domain.Core;

namespace TechSnacks.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Guid productId, decimal price, int quantity)
        {
            ProductId = productId;
            Price = price;
            SetQuantity(quantity);
        }

        public Guid ProductId { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public void AddQuantity(int quantity)
        {
            ValidateItemQuantity(quantity);

            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            ValidateItemQuantity(quantity);

            Quantity = quantity;
        }

        private static void ValidateItemQuantity(int quantity)
        {
            if (quantity == 0 || quantity > int.MaxValue)
                throw new ArgumentOutOfRangeException($"An item quantity must be between 0 and {int.MaxValue}");
        }
    }
}
