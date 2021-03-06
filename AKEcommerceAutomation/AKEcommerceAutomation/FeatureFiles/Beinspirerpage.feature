﻿Feature: Be-InspiredPage
	
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

Scenario: Navigating to the Light box and verifying suggested Journeys
When I Click on Find Out More link on an image
Then Light box appears with Suggested Journeys

Scenario: Verifying MyPinboard toolbar links.
When I click on MyPinboard Page
Then MyPinboard toolbar links appears

Scenario: Delete images in my pinboard
When I Navigate to Mypinboard
And I click on delete button
Then Images are deleted from MyPinboard

Scenario: Delete entire images in Pinboard
When I add image to my pinboard
And I click on delete button on pinboard toolbar
Then Entire images are deleted from MyPinboard page

Scenario: Verifying the Share Pinboard links navigating to Right pages
Given I am on MyPinboard page
When I Click on Share Pinboard Icons
Then Each Icon Navigates to right page

Scenario: Send MyPinboard to a Friend
When I click on send to a friend icon
And I fill in the text fields with valid details
Then Mypinboard send to a Friend email address