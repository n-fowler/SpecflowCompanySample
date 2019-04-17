using System.Collections.Generic;
using System.Linq;

namespace TakeHomeAssignment.Models
{
    public class Order
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public int PercentageDiscount
        {
            get
            {
                if (this.Items == null || this.Items.Sum(i => i.Quantity) <= 10)
                {
                    return 0;
                }

                if (this.Items.Sum(i => i.Quantity) > 10 && this.Items.Sum(i => i.Quantity) <= 20)
                {
                    return 5;
                }

                if (this.Items.Sum(i => i.Quantity) > 20 && this.Items.Sum(i => i.Quantity) <= 30)
                {
                    return 10;
                }

                return 20;
            }
        }

        public double? OrderTotal
        {
            get
            {
                var total = this.Items?.Sum(i => i.Price * i.Quantity);

                var discount = this.PercentageDiscount;

                return total - total * (discount / 100);
            }
        }
    }
}