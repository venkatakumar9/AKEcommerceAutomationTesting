Feature: Be-InspiredPage
	
#@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

Scenario: Verifying the navigation in Be-inspired page
Given I am on the AK homepage
When I click on BeInspired tab on homepage
Then Be-inspired Navigation Links displayed:
| Value              |
| PLACES TO VISIT    |
| THINGS TO SEE & DO |
| WHERE TO STAY      |
| MY PINBOARD        |

