Feature: Employee
	Verify Benefits create Employee
	
Background: 
	Given: I delete employee 'AutoUser' before I start running test

@smoke
Scenario: Create Employee with all details
	Given I have navigatged to the application
	And I see application opened 
	Then I click login link
	When I enter UserName and Password
	| UserName | Password |
	| admin    | password |
	Then I click Login button
	And I click employeeList link
	Then I click createnew button
	And I enter following details
	| Name     | Salary | DurationWorked | Grade | Email           |
	| AutoUser | 4000   | 30             | 1     | autouser@ga.com |
	And I click create button
