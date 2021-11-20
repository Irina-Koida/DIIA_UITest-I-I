using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UITest.POM;

namespace DIIA_UITest.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly SearchFromMainMenu _searchFromMainMenu;
        private readonly IWebDriver _webDriver;
        private readonly MainPage _mainPage;

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _searchFromMainMenu = new SearchFromMainMenu(_webDriver);
            _mainPage = new MainPage(_webDriver);
        }

        [Given(@"Main page is open")]
        public void GivenMainPageIsOpen()
        {
            _mainPage.GoToMainPage();
        }

        [When(@"I input ""(.*)"" in the search field")]
        public void WhenIInputInTheSearchField(string inputValid)
        {
            _searchFromMainMenu.InputOnSearchInformationField(inputValid);
        }

        [When(@"I click a search button")]
        public void WhenIClickASearchButton()
        {
            _searchFromMainMenu.ClickOnSearchInformationField();
        }

        [Then(@"I see a open  search page with text ""(.*)""")]
        public void ThenISeeAOpenSearchPageWithText(string text) => _searchFromMainMenu.SearchInfoRequestText(text);
    }
}
