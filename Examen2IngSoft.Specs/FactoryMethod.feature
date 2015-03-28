Feature: FactoryMethod

@mytag
Scenario: Add two numbers
	Given the first number 1 
	And the second number 3 
	Then the addition result should be 4 

Scenario: Substract two numbers
	Given the first number 5 
	And the second number 6 
	Then the substraction result should be -1 

Scenario: Multiply two numbers
	Given the first number 4 
	And the second number 3
	Then the multiplication result should be 12
