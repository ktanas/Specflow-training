Feature: Test if a person of a given age can drive a car in specified country - case 3

@mytag
Scenario: Driver from United States eligible for driving
	Given Driver is 16 years old
	And Driver lives in UnitedStates
	Then Driver can drive

