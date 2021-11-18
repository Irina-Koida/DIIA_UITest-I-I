using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using DIIA_UITest.POM;

namespace DIIA_UITest.Steps
{
    [Binding]
    public class ServicesSubMenuSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly ServiceSwiperPage _serviceSwiperPage;

        public ServicesSubMenuSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _serviceSwiperPage = new ServiceSwiperPage(_webDriver);
        }

        [Given(@"Main page is open")]
        public void GivenMainPageIsOpen()
        {
            _serviceSwiperPage.GoToServiceSwiperPage();
        }
    }
}
