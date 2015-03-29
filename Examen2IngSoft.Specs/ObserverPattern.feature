Feature: ObserverPattern
	
@mytag

Scenario: save average all class I a class change one of its operands
	Given I the sum change value 1 to 2
	And   resul the sum is 5 
	And   a read text file
	Then average value is updated automatically is 5.0
