Feature: FactoryMethod

@mytag
Scenario: Add two numbers
	Given a text file	
	And two addition numbers	
	Then the addition result should be 4 

Scenario: Substract two numbers
	Given a text file
	And two substraction numbers	
	Then the substraction result should be -1 

Scenario: Multiply two numbers
	Given a text file
	And two multiplication numbers
	Then the multiplication result should be 12
