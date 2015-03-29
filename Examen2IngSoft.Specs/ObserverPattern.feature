Feature: ObserverPattern
	
@mytag
Scenario: save average all class
	Given I a class change one of its operands
	And I the sum change 1 value 2
	And resul the sum is , now would be 2+3=5
	When is calculate
	Then average value us updated automatically
