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
        }

        [When(@"I view the checkout summary")]
        public void WhenIViewTheCheckoutSummary()
        {
            this.order = this.orderApi.GetOrder();
        }

        [Then(@"there is a (.*)% discount applied")]
        public void ThenThereIsADiscountApplied(int discount)
        {
            //TODO verify the correct discount
            ScenarioContext.Current.Pending();
        }


    }
}

