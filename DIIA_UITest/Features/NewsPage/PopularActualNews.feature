Feature: PopularActualNews
As a user
I want see a news on the news page
In order to read the news

Background:
	Given News page is open

@news
Scenario: Check navigation to the news page from the block with news
	When I click on the first news
	Then I navigate to the news page

@news
Scenario: Check that more news is shown when you click the More News button
	When I click "Більше новин" button
	Then The six block of news are shown

@news
Scenario: Check that there is a block with the latest news on the page of the selected news
	When I selected a news
	Then I see a block with the latest news below, under the selected news

@news
Scenario: Check that the selected news page has the option to share this news on social networks
	When I selected a news
	Then I see the block "Поділитись новиною" to the right of the selected news