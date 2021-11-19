Feature: LanguageSwicherButton
	As a visitor of site
	I want to manage OsvitaPage language 
	In order to make page information more understable

Background:
	Given Osvita page is open

Scenario: Change Osvita page language by header navigate
	When move to header
	When I click to LanguageSwicher button
	When I swich language from dropdown
	When I wait to reload page
	Then The text on Osvita page change to selected