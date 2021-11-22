Feature: SelectedNewsPage
	Simple calculator for adding two numbers


@selectednews
Scenario: Check that there is a block with the latest news on the page of the selected news
	When I click on the first news
	When I navigate to the news page
	Then I see a block with the latest news below, under the selected news

@selectednews
Scenario: Check that the selected news page has the option to share this news on social networks
	When I click on the first news
	When I navigate to the news page
	Then I see the block "Поділитись новиною" to the right of the selected news
