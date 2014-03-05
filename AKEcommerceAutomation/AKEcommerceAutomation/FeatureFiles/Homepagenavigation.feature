Feature: Homepagenavigation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

 Scenario: Navigate to Destinations Homepage
 When I Click on Destinations Link
 Then I navigate to Destinations homepage

 Scenario: Navigate to BeInspired Page
 When I click on BeInspired link
 Then I Navigate to BeInspired Page

 Scenario: Main Navigation Links Working
 Given I am on the homepage
 When I Mouse Over on Destinations Link
 Then The Meganav Appears
 | Value                      |
 | AFRICA                     |
 | THE AMERICAS               |
 | ASIA                       |
 | CARIBBEAN                  |
 | EUROPE                     |
 Then The Meganav bottom appears
 |Value                       |
 | MIDDLE EAST & NORTH AFRICA |
 | AUSTRALIASIA               |
 | ANTARCTICA & THE ARCTIC    |
 | INDIA, HIMALAYAS & INDIAN OCEAN |
 And When I click on Destination link I reach the Destinations Page
 And When I click on Journeys Link I reach Journeys Page
 And When I click on BeInspired Link I reach BeInspired Page

 Scenario: Mega Menu Country Links Working
 Given I am on the homepage
 When I Mouse Over on Destinations Link
 Then All the coutries in the continents will appear.
