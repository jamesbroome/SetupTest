Feature: BigBang
	In order to work smarter not harder
	As an endjineer
	I want to automate setting up a new project

Scenario: Big Bang set up
	Given I have created a new project
	And I have created a new build definition
	When I run the build
	Then the everything should work first time
