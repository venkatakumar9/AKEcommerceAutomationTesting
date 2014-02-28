Feature: Continent Page
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

Scenario: When I Click on Africa in Megamenu I reach the Africa Continent Page
Given I am on the homepage
When I Mouse Over on Destinations Link
Then The Meganav Appears
When I click on The Africa
Then I reach the Africa Continent Page


