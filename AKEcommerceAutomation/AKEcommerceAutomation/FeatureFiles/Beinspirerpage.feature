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

Scenario: Delete the Inspirer Instructional text and cookies to re-enable the Inspirer Instructional text
Given I am on beinspired page
When I close the Inspirer Instructional text
And I delete all the cookies in the browser
Then Inspirer Instructional text re-appears.

Scenario: Verify Inspirer Categories in Be-inspired page
When I navigate to beinspired page
Then inspirer category images appears

Scenario: verifying inspirer images when clicked on PLACES TO VISIT category
When I click on Places to visit inspirer category
Then Inspirer images should appear

Scenario: Verifying inspirer images when clicked on THINGS TO SEE & DO category
When I click on THINGS TO SEE AND DO inspirer category
Then Inspirer images appear

Scenario: Verifying inspirer images when clicked on WHERE TO STAY category
When I click on where to stay inspirer category
Then where to stay inspirer images displays

Scenario: Verifying the pinboard count in Mypinboard and in Right Hand Side Bar when user adds any image to Pinboard.
When I add an image to my pinboard
Then Pinboard count appears on My Pinboard and on Right Hand Bar



