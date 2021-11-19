using OpenQA.Selenium;

namespace DIIA_UITest.POM
{
    public class SearchFromMainMenu
    {
        private readonly IWebDriver _webDriver;

        public SearchFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SearchFromMainMenu GoToMainPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

        private readonly By _clickOnSeachInformationField = By.CssSelector("[class='input form-search_input']");
        private readonly By _clikOnSearchInfoButton = By.CssSelector("[type='submit']");
        private readonly By _searchRequestTextInfo = By.CssSelector("[class = 'search_request-text']");
        private readonly By _cookieClose = By.CssSelector("[class = 'cookies-1_close']");

        public void ClickOnSearchInformationField()
        {
            _webDriver.FindElement(_clikOnSearchInfoButton).Click();
        }

        public SearchFromMainMenu InputOnSearchInformationField(string input)
        {
            _webDriver.FindElement(_clickOnSeachInformationField).SendKeys(input);
            _webDriver.FindElement(_cookieClose).Click();

            return this;
        }

        public string SearchInfoRequestText(string text) =>
         _webDriver.FindElement(_searchRequestTextInfo).Text;
  
    }
}
