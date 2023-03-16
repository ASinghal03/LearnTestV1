Feature: TMFeature1

A short summary of the feature

@tag1
Scenario: Create Time & Materials New Record
	Given I logged into portal successfully
	When I navigate to TM page
	And I create a new record
	Then The record is created successfully

Scenario Outline: Edit an existing record
	Given I logged into portal successfully
	When I navigate to TM page
	And IUpdate '<code>','<price>','<desc>' to an existing record
	Then '<code>','<price>','<desc>' is modified successfully

Examples:
| code         | price | Desc |
| time         | 12    | abc  |
| price        | 13    | bcd  |
| updateRecord | 14    | efg  |
