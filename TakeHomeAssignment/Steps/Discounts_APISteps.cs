using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TakeHomeAssignment.Api;
using TakeHomeAssignment.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TakeHomeAssignment.Steps
{
    [Binding]
    public class Discounts_APISteps
    {
        private readonly OrderApi orderApi;
        private Order order;

        public Discounts_APISteps(OrderApi orderApi)
        {
            this.orderApi = orderApi;
        }

        [Given(@"I have (.*) items in my order")]
        public void GivenIHaveItemsInMyOrder(int itemQuantity)
        {
            this.orderApi.CreateOrder();
            this.orderApi.AddItem("TestProduct", itemQuantity, 5.0);

        }

        [Given(@"I have (.*) items of (.*) with a price of (.*) in my order")]
        public void GivenIHaveMultipleUniqueItemsInMyOrder(int itemQuantity, string itemName, double itemPrice)
        {
            if (order == null)
            {
                order = this.orderApi.CreateOrder();
            }

            this.orderApi.AddItem(itemName, itemQuantity, itemPrice);
        }

        [Given(@"I have the following items in my cart")]
        public void GivenIHaveTheFollowingItemsInMyCart(Table table)
        {
            if (order == null)
            {
                order = this.orderApi.CreateOrder();
            }

            IEnumerable<Item> items = table.CreateSet<Item>();

            foreach (Item item in items)
            {
                this.orderApi.AddItem(item.Name, item.Quantity, item.Price);
            }
        }

        [When(@"I view the checkout summary")]
        public void WhenIViewTheCheckoutSummary()
        {
            this.order = this.orderApi.GetOrder();
        }

        [Then(@"there is a (.*)% discount applied")]
        public void ThenThereIsADiscountApplied(int discount)
        {
            Assert.AreEqual(discount, this.order.PercentageDiscount);

            var expectedTotal = this.order?.Items?.Sum(i => i.Price * i.Quantity);
            var expectedDiscountedTotal = expectedTotal - expectedTotal * (discount / 100);
            Assert.AreEqual(expectedDiscountedTotal, order.OrderTotal);
        }
    }
}

