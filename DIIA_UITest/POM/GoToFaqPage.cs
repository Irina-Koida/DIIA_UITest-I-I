using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIIA_UITest.POM
{
    class GoToFaqPage
    {
        private readonly IWebDriver _webDriver;

        public GoToFaqPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public By _allQuestionAndAnswerButton = By.CssSelector(".wrap-all-link_link > span");
        public By _faqPageHeaderMessage = By.CssSelector(".article-level-1");

        public void ClickOnQuestionAndAnswerButton()
        {
            _webDriver.FindElement(_allQuestionAndAnswerButton).Click();
        }

        public void WelcomeFaqPageText()
        {
            _webDriver.FindElement(_faqPageHeaderMessage);
        }
    }
}
