Feature: TMFeature1

A short summary of the feature

@tag1
Scenario: Create Time & Materials New Record
	Given I logged into portal successfully
	When I navigate to TM page
	And I create a new record
	Then The record is created successfully
