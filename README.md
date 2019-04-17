# SpecflowCompanySample
```
Engineer Notes:

Initial tests were failing so I made the following changes:

Updates to Order.cs
From < 10 to <= 10 on line 13

The feature had a small typo for the 20-30 items section.  Based on code, and the previous section,
it looks like it was intended to be 21-30 so the tests are set to that.

There are some additional/alternate tests I could would make here:

Additional:

Adding/removing items and checking that the discount is applied properly
updating item prices and checking that the discount is applied properly

Alternate:

Specflow allows the use of tables so there might be a circumstance under which
I would supply a table such as below to the test scenario instead.

Scenario: Orders with 11 items receive a 5% discount
 Given I have 11 items in my order
 And I view the checkout summary
 When I supply the following cart
 | Name        | Price | Quantity |
 | TestItemOne | 5.0   | 5        |
 | TestItemTwo | 2.0   | 6        |
 Then there is a 5% discount applied
```
