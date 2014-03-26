Feature: AccommodationsPage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Reaching the Sanctuary Chobe Chilwero Accomodation Page
Given I am on the HomePage
And I reach Africa Continent page
And I reach the Botswana Page
And I reach the Chobe Area page
When I click on Accommodations tab
Then All the Avialable Accomodatioons are present
When I click on Sanctuary Chobe Chilwero
Then I reach Sanctuary Chobe Chilwero Accomodation page

Scenario: Verify the hero Image
Given There is a Accomodation image in the Area page
When I reach the Accomodation page
Then the Hero image is present in accomodation page

Scenario: Verify the map in the Accomodation Page
Given I reach the Accomodation page
Then the map is present