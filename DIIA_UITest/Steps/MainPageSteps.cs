using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using DIIA_UITest.POM;

namespace DIIA_UITest.Steps
{
    [Binding]
    public sealed class MainPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ServiceSwiperPage _serviceSwiperPage;

        public MainPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _serviceSwiperPage = new ServiceSwiperPage(webDriver);
        }

        [Given(@"Sign in page is opened")]
        public void GivenSignInPageIsOpened()
        {
            _serviceSwiperPage.GoToServiceSwiperPage();            
        }
    }
}
