# SpecflowCompanySample

Assignment
Please write test cases for the following feature and describe how you would automate testing.  Email if  you have any questions or need clarifications.  Please explain any assumptions you made while writing tests.

We currently use the Gherkin syntax with SpecFlow and Cucumber for our test cases.  So a sample test may look like:

Scenario: Orders with 11- 20 items receive a 5% discount
Given I have 14 items in my order
When I view the checkout summary
Then there is a 5% discount applied

Ideally the submission would be in the form of a code project either zipped or a link to a GitHub project.  Even better if the submission is in C# using SpecFlow.  However, if you are the right candidate we know you’ll be able to pick up a new technology so you can submit test cases in any format you’re comfortable with.

Feature:
Will will be offering discounts on larger quantities of orders according to the following schedule.  The discount will apply when viewing the order summary endpoint.

The endpoint is /api/1.0/order_summary/{order_id} and an example response model is:
{
  "items": [{
      "name": "widget 1",
      "price": {
        "type": "USD",
        "value": 10.1
      },
      "quantity": 2
    },
    {
      "name": "widget 2",
      "price": {
        "type": "USD",
        "value": 4.2
      },
      "quantity": 6,
    }
  ]
  “order_total”: 45.4,
  “discount”: 0
}



Item Count	Discount 
0 - 10 items	0% (no discount)
11-20 items	5%
21-30 items	10%
31+ items	20%


Bonus: 
Use the attached solution to write acceptance tests for the feature.  There is a sample project in place allows creating and adding items to an order.
Here is some information on SpecFlow if you're not familiar with it https://specflow.org/getting-started/

