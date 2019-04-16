using TakeHomeAssignment.Models;

namespace TakeHomeAssignment.Api
{
    public class OrderApi
    {
        private Order order;

        public Order CreateOrder()
        {
            this.order = new Order();
            return this.order;
        }

        public Order AddItem(string name, int quantity, double value)
        {
            this.order.Items.Add(new Item
            {
                Name = name,
                Price = value,
                Quantity = quantity
            });
            return order;
        }

        public Order GetOrder()
        {
            return this.order;
        }
    }
}
