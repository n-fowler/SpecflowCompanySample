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