Feature: UserStory1
As a user if there is an item already inside my basket, I want to be able to delete the item
from the basket page so that I can see the basket is empty.

@Userstory1
Scenario: Validate empty basket
	Given I add a faded short sleeve t-shirt to the cart
	And I navigate to the cart
	When I select the delete icon
	Then I should be presented with a banner that statesyour shopping cart is empty
