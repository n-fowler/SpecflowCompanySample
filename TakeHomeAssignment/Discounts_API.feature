Feature: Discounts_API

Scenario: Orders with 0 items receive a 0% discount
Given I have 0 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 10 items receive a 0% discount
Given I have 10 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 11 items receive a 0% discount
Given I have 11 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 20 items receive a 0% discount
Given I have 20 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 0 items receive a 0% discount
Given I have 0 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 0 items receive a 0% discount
Given I have 0 items in my order
When I view the checkout summary
Then there is a 0% discount applied

Scenario: Orders with 0 items receive a 0% discount
Given I have 0 items in my order
When I view the checkout summary
Then there is a 0% discount applied