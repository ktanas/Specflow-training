Feature: Test if a person of a given age can drive a car in specified country - case 2

@mytag
Scenario: Driver from Poland ineligible for driving
	Given Driver is 16 years old
	And Driver lives in Poland
	Then Driver cannot drive

