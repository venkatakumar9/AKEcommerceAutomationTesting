Feature: Destinationpage	

#@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

Scenario: When I click on Destination link i reach the destination page
Given  I am on the HomePage
And I click on Destination Link
Then I reach the destination page
And The Vector map is present


Scenario: When I Click on The Americas
Given I am on the destination page
And The Vector Map is present
When I click on The Americas in Vector map
Then I reach the Americas page

Scenario: When I Click on the Africa
Given I am on the destination page
And The Vector Map is present
When I click on The Africa in Vector map
Then I reach the Africa page

Scenario: When I Click on the The Europe
Given I am on the destination page
And The Vector Map is present
When I click on The Europe in Vector map
Then I reach the Europe page

Scenario: When I Click on the The Caribbean
Given I am on the destination page
And The Vector Map is present
When I click on The  Caribbean in Vector map
Then I reach the  Caribbean page

Scenario: When I Click on the The Autralia and Newzealand
Given I am on the destination page
And The Vector Map is present
When I click on The Autralia and Newzealand in Vector map
Then I reach the Autralia and Newzealand page

Scenario: When I Click on the The Middle East And North Africa
Given I am on the destination page
And The Vector Map is present
When I click on The Middle East And North Africa in Vector map
Then I reach the Middle East And North Africa page

Scenario: When I Click on the The India And The Himalayas
Given I am on the destination page
And The Vector Map is present
When I click on The India And The Himalayas in Vector map
Then I reach the India And The Himalayas page

Scenario: When I Click on the The Indian ocean
Given I am on the destination page
And The Vector Map is present
When I click on The Indian ocean in Vector map
Then I reach the Indian ocean page