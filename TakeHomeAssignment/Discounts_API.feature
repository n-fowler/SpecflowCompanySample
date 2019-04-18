Feature: Discounts_API

Scenario: Orders with 0 items receive a 0% discount
Given I have 0 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 10 items receive a 0% discount
Given I have 10 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 11 items receive a 5% discount
Given I have 11 items in my order
When I view the checkout summary
Then there is a 5% discount applied

Scenario: Orders with 20 items receive a 5% discount
Given I have 20 items in my order
When I view the checkout summary
Then there is a 5% discount applied

Scenario: Orders with 21 items receive a 10% discount
Given I have 21 items in my order
When I view the checkout summary
Then there is a 10% discount applied

Scenario: Orders with 30 items receive a 10% discount
Given I have 30 items in my order
When I view the checkout summary
Then there is a 10% discount applied

Scenario: Orders with 31 or more items receive a 20% discount
Given I have 31 items in my order
When I view the checkout summary
Then there is a 20% discount applied

Scenario: Orders with 100 or more items receive a 20% discount
Given I have 100 items in my order
When I view the checkout summary
Then there is a 20% discount applied

Scenario: Orders with 1000 or more items receive a 20% discount
Given I have 1000 items in my order
When I view the checkout summary
Then there is a 20% discount applied

Scenario: Orders with 11 items and two unique products recieve a 5% discount
Given I have 5 items of Widget One with a price of 5.00 in my order
And I have 6 items of Widget Two with a price of 10.00 in my order
When I view the checkout summary
Then there is a 5% discount applied

Scenario: Orders with 30 items in their cart receive a 10% discount
 Given I have the following items in my cart
 | Name          | Price | Quantity |
 | Widget One    | 5.0   | 5        |
 | Widget Two    | 2.0   | 6        |
 | Widget Three  | 4.0   | 2        |
 | Widget Four   | 7.0   | 7        |
 | Widget Five   | 6.0   | 4        |
 | Widget Six    | 11.0  | 5        |
 | Widget Seven  | 35.0  | 1        |
 When I view the checkout summary
 Then there is a 10% discount applied