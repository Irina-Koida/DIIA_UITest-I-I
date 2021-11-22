using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIIA_UITest.POM
{
    public class SearchFromMainMenu
    {
        private readonly IWebDriver _webDriver;

        public SearchFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickOnSeachInformationField = By.CssSelector("[class='input form-search_input']");
        private readonly By _searchRequestTextInfo = By.CssSelector("[class = 'search_request - text']");

        public void InputOnSearchInformationField(string input)
        {
            _webDriver.FindElement(_clickOnSeachInformationField).SendKeys(input);
            _webDriver.FindElement(_clickOnSeachInformationField).SendKeys(Keys.Enter);
        }

        public void ClickOnSearchInformationField()
        {
            _webDriver.FindElement(_clickOnSeachInformationField).Click();
        }

        public void SearchInfoRequestText()
        {
            _webDriver.FindElement(_searchRequestTextInfo);
        }
    }
}
