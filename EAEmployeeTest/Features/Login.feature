Feature: Login
	Check if the login functionality is working 
	as expected with different scenario

Background: 
	#Given: I delete employee 'AutoUser' before I start running test
@smoke @positive
Scenario: Check Login with correct username and password
	Given I have navigatged to the application
	And I see application opened 
	Then I click login link
	When I enter UserName and Password and click Login
	| UserName | Password |
	| admin    | password |
	Then I click Login button
	Then I should see the username with hello

