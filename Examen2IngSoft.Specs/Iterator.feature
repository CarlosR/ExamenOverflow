Feature: Iterator

@mytag
Scenario: HappyPath
	Given the result for HappyPath of an addition is 4 
	And the result for HappyPath of a substraction is -1 
	And the result for HappyPath of an multiplication is 12 
	Then the results in the log screen should be "Suma 4", "Resta -1", "Multiplicacion 12"