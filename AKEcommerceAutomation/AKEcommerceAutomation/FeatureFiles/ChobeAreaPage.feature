Feature: ChobeAreaPage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Reaching the Chobe Area Page
Given I am on the HomePage
And I reach Africa Continent page
And I reach the Botswana Page
When I Click on AREAS
Then All the Areas with offers are available
When I click on Chobe 
Then I reach Chobe area page

Scenario: Validate the navigation links in the area page
Given I reach the Chobe Area Page
Then All the navigation links appear
| Value                 |
| OVERVIEW              |
| GUIDED GROUP JOURNEYS |
| TAILOR MADE JOURNEYS  |
| ACCOMMODATIONS        |
| INSIDER ACCESS        |
| USEFUL INFO           |

Scenario: Validate the map in Area page
Given I reach the Chobe Area Page
Then the map is present in the overview page

Scenario: Verify the hero Image
Given There is a Area image in the Country page
When I reach the Chobe Area Page
Then the Hero image is present in area page

Scenario: Validate the Guided Group Jouneys
Given I reach the Chobe Area Page
When I click on Guided Group journeys
Then All the Guided Group Journeys with offers are Appeared

Scenario: Validate the Tailor Made Journeys
Given I reach the Chobe Area Page
When I click on Tailor Made Journeys
Then All the Taiolor made Journeys with offers are appeared

Scenario: Validate Accomodations in the Area page
Given I reach the Chobe Area Page
When I Click on Accomodations 
Then I can view all the Accomodations available

Scenario: Validate Inside Access in the Area Page
Given I reach the Chobe Area Page
When I click on Insider Access
Then Enquire button is present

Scenario: Validate Useful Info in the Area page
Given I reach the Chobe Area Page
When I click on useful info 
Then Enquire, Print buttons are present