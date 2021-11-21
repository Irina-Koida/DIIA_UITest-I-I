Feature: Language Swicher Button
	As a visitor of site
	I want to manage Osvita Page language 
	In order to make page information more understable to me

Background:
	Given Osvita page is open

Scenario: Change Osvita page language
	When Move to header
	When I click to Language Swicher button
	When I switch language from dropdown
	When I wait to reloading the page
	Then The text on Osvita page has changed to the selected language

	#Move to header,I wait to reloading the page - how can you avtomaite this?