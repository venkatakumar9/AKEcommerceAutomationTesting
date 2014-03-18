Feature: AfricaContinentpage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	#Given I have entered 50 into the calculator
	#And I have entered 70 into the calculator
	#When I press add
	#Then the result should be 120 on the screen

Scenario: When I Click on Africa in Megamenu I reach the Africa Continent Page
 Given I am on the homepage
 When I Mouse Over on Destinations Link
 Then The Meganav Appears
 | Value                      |
 | AFRICA                     |
 | THE AMERICAS               |
 | ASIA                       |
 | CARIBBEAN                  |
 | EUROPE                     |
 When I click on The Africa Continent
 Then I reach Africa Continent page

 Scenario: Verifying the navigation in the African continent page
  Given I reach Africa Continent page
  Then The Navigation links are present
  | Value                 |
  | OVERVIEW              |
  | COUNTRIES             |
  | GUIDED GROUP JOURNEYS |
  | TAILOR MADE JOURNEYS  |
  | INSIDER ACCESS        |
  When I click on the navigation links
  Then I reach the specific pages in the continent page 
    
 Scenario: Verifying Vector map in the African Continent page
 Given I reach Africa Continent page
 Then Africa Country Vector map is present
 When I click on SouthAfrica in Vector map
 Then I reach South Africa Page

 Scenario: Verifying Carousel Images in African Continet page
 Given I reach Africa Continent page
 Then the carousel Image is present

