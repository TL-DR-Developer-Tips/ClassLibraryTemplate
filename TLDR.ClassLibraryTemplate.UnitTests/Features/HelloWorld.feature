Feature: HelloWorld
	This is a feature to demo how this feature was copied when the template was created
@mytag
Scenario: Greeting returns --> name, hello world
	Given I have a hello world class
	And I have a inputName of 'John'
	When I call the Greeting method and pass in the name
	Then the result should contain be 'John, hello world.'

	
Scenario: Greeting with null in[ut return argument exception
	Given I have a hello world class 
	When I call the Greeting method and pass in the name
	Then the result should be an exception with the typoe of "ArgumentException" 
		
	
Scenario: Calling Whodis returns random name
	Given I have a hello world class 
	When I call the WhoDis method
	Then the result should a random string


	