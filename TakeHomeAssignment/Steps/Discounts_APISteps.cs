using NUnit.Framework;
using System.Linq;
using TakeHomeAssignment.Api;
using TakeHomeAssignment.Models;
using TechTalk.SpecFlow;

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
        public void GivenIHaveItemsInMyOrder(int itemCount)
        {
            this.orderApi.CreateOrder();
            this.orderApi.AddItem("TestProduct", itemCount, 5.0);

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

