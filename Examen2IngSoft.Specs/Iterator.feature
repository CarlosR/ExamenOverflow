Feature: Iterator

@mytag
Scenario: HappyPath
	Given the result of an addition is 4
	And the result of a substraction is -1
	And the result of an multiplication is 12
	Then the results in the log screen should be 'Suma 4', 'Resta -1', 'Multiplicacion 12'
