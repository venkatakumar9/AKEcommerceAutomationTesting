Feature: Specialofferpage
	

@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

Scenario: Verifying the Special Offers Navigation links
Given I am on the AK homepage
When I click on Special offers link in header
Then Special offers page appear
And special offers navigation exists

