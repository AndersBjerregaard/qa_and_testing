Feature: Basket
	Basket stuff

@BasketStuff
Scenario: Add Two Items to Basket and Check Total Price
	Given I have an empty basket
	And the price of a/an "Book" is $10.00
	And the price of a/an "DVD" is $5.00
	When I add a "Book" to the basket
	And I add a "DVD" to the basket
	And I add a "DVD" to the basket
	Then the total price of the basket contents should be $20.00
	And the total price of the "Book" in the basket should be $10.00
	And the total price of the "DVD" in the basket should be $10.00