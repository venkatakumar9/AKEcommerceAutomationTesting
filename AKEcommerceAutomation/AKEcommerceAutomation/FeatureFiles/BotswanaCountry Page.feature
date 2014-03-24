Feature: Botswana Country Page
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Verify the navigation links in the country page
Given I reach the Botswana Page
Then The Navigation Links are present
|Value|
| OVERVIEW              |
| AREAS                 |
| GUIDED GROUP JOURNEYS |
| TAILOR MADE JOURNEYS  |
| ACCOMMODATIONS         |
| INSIDER ACCESS        |
| USEFUL INFO           |

Scenario: Verify the map in the Country Page
Given I reach the Botswana Page
When I click on the overview tab
Then the map is present

Scenario: Verify the hero Image
Given There is a country image in the continent page
When I reach the Botswana Page
Then the Hero image is present

Scenario: Validate the Area Page in the Country Page
Given I reach the Botswana Page
When I Click on AREAS 
Then All the Areas with offers are available

Scenario: Validate the Guided Group Jouneys
Given I reach the Botswana Page
When I click on Guided Group journeys
Then All the Guided Group Journeys with offers are Appeared

Scenario: Validate the Tailor Made Journeys
Given I reach the Botswana Page
When I click on Tailor Made Journeys
Then All the Taiolor made Journeys with offers are appeared

Scenario: Validate Accomodations in the country page
Given I reach the Botswana Page
When I Click on Accomodations 
Then I can view all the Accomodations available