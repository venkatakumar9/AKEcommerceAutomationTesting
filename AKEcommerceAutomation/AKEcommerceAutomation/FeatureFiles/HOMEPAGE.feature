Feature: HOMEPAGE
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@mytag
#Scenario: Add two numbers
#	Given I have entered 50 into the calculator
#	And I have entered 70 into the calculator
#	When I press add
#	Then the result should be 120 on the screen

 Scenario: Verify Footer High Level Links in the Homepage
 When I Navigate to Homepage
 Then Footer Links should Display


 Scenario: Verify the SideBar, middlesection and journeys appearing on the Homepage
 Given I am on the homepage
 Then SideBar Displays
 And Middle Section of the Homepage Appears
 And Guided Group Journeys section Displays
 And Tailor Made Journeys section Displays
 
 Scenario: Navigate to Destinations Homepage
 When I Click on Destinations Link
 Then I navigate to Destinations homepage

  Scenario: Verify Sub Navigation Menu in Homepage
 #When I am in the AK Homepage
 Then SubMenu Appears:
 |Value|
 |DESTINATION|
 |JOURNEYS|
 |BEINSPIRED|
 |WHEN TO GO|
 |SEARCH|

 Scenario: Verify the SideBar appears on the page
 Given I am on the homepage
 Then SideBar Displays
 And Carousel Main image displays

 Scenario: Top Header links in homepage
 When I am on the Homepage
 Then Top Headerlinks displays
 |Value|
 |About Us|
 |Specials|
 |Media centre|
 |Contact us|
 |More|
 |Sign in| 

    