Feature: Go To FAQ Page
As a visitor of site 
I want to easily find the FAQ page 
In order to easily get answers to my questions

Background:

Given Main page is open
@FAQ
Scenario: Go to FAQ page by clicking 'Всі питання та відповіді' button
	When I move to 'Питання та відповіді' block
	When I click on 'Всі питання та відповіді' button
	Then I navigate to the FAQ Page with Faq Header text

	#Scenario: Go to FAQ page from Питання та відповіді by clicking arrow button
	#	When I move to 'Питання та відповіді' block
	#	When I click on ''