﻿Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@mytag
Scenario: As User I enter wp.pl and try login to e-mail account
Given I enter wp.pl
And I click on <poczta>
When I fill wrong email login
And I fill wrong password
And I press submit
Then I expect to see message as „Niestety podany login lub hasło jest błędne.”
