Feature: BeAmbassadorForm
	As a National comunity
	I want to create special form for become ambassador
	In order to involve more members to educate community

Background:
	Given Osvita page is open

@Osvita
Scenario: Fill the ambassador form
	When I go to footer page
	When I click to Be Ambassador button
	When I navigate to Ambassador page
	When I fill the Be Ambassador form fields
	Then I see Thanks Page with thanks massage