using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using DIIA_UITest.POM;

namespace DIIA_UITest.Steps
{
    [Binding]
    public class PopularActualNewsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PopularActualNews _popularActualNews;
        private readonly IWebDriver _webDriver;

        public PopularActualNewsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _popularActualNews = new PopularActualNews(_webDriver);
        }

        [Given(@"News page is open")]
        public void GivenNewsPageIsOpen()
        {
            _popularActualNews.GoToNewsPage();
        }

        [When(@"I click on the more news button")]
        public void WhenIClickOnTheMoreNewsButton()
        {
            _popularActualNews.СlickMoreNewsButton();
        }
        
        [When(@"I click the next page button")]
        public void WhenIClickTheNextPageButton()
        {
            _popularActualNews.СlikNextPageButton();
        }
        
        [When(@"I click the previous page button")]
        public void WhenIClickThePreviousPageButton()
        {
            _popularActualNews.ClikPreviousPageButton();
        }
        
        [When(@"I click on the first news")]
        public void WhenIClickOnTheFirstNews()
        {
            _popularActualNews.GoToSelectNewsPage();
        }
        
        [Then(@"The pagination number of next page are active")]
        public void ThenThePaginationNumberOfNextPageAreActive()
        {
            _popularActualNews.SeeAActivePlaginationNextPage();
        }
        
        [Then(@"I navigate to the next page")]
        public void ThenINavigateToTheNextPage()
        {
            _popularActualNews.SeeAActivePlaginationNextPage();
        }

        [Then(@"I navigate to the previous page")]
        public void ThenINavigateToThePreviousPage()
        {
            _popularActualNews.SeeAActivePlaginationPreviousPage();
        }
        
        [Then(@"I navigate to the news page")]
        public void ThenINavigateToTheNewsPage()
        {
            _popularActualNews.GoToSelectNewsPage();
        }
    }
}
