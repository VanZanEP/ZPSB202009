﻿Feature: SpecFlowFeature1
	Simple e-mail login

@mytag
Scenario: As User I enter wp.pl and try login to e-mail account
Given I enter onet.pl
And I click on <poczta>
When I fill wrong email login
And I fill wrong password
And I press submit
Then I expect to see message as „Niestety podany login lub hasło
jest błędne.”