Feature: Test if a person of a given age can drive a car in specified country

@mytag
Scenario: Driver from Poland eligible for driving
	Given Driver is 18 years old
	And Driver lives in Poland
	Then Driver can drive

