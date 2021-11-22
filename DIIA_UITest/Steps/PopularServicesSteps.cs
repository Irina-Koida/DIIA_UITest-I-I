﻿using OpenQA.Selenium;
using TechTalk.SpecFlow;
using DIIA_UITest.POM;

namespace DIIA_UITest.Steps
{
    [Binding]
    public class PopularServicesSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly PopularServisesFromMainMenu _popularServisesFromMainMenu;
        private readonly IWebDriver _webDriver;

        public PopularServicesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>("WebDriver");
            _popularServisesFromMainMenu = new PopularServisesFromMainMenu(_webDriver);
        }

        [When(@"I click on the first service")]
        public void WhenIClickOnTheFirstService()
        {
            _popularServisesFromMainMenu.GoToPopularServicePage();
        }

        [When(@"I click on the swiper rigt button")]
        public void WhenIClickOnTheSwiperRigtButton()
        {
            _popularServisesFromMainMenu.SwipeToTheRightClick();
        }

        [When(@"I click on the swiper left button")]
        public void WhenIClickOnTheSwiperLeftButton()
        {
            _popularServisesFromMainMenu.SwipeToTheLeftClick();
        }

        [When(@"I click on the right side of the pagination bullet bar")]
        public void WhenIClickOnTheRightSideOfThePaginationBulletBar()
        {
            _popularServisesFromMainMenu.ClickToTheRightSide();
        }

        [When(@"I click on the left side of the pagination bullet bar")]
        public void WhenIClickOnTheLeftSideOfThePaginationBulletBar()
        {
            _popularServisesFromMainMenu.ClickToTheLeftSide();
        }

        [Then(@"I navigate to the service page")]
        public void ThenINavigateToTheServicePage()
        {
            _popularServisesFromMainMenu.GoToPopularServicePage();
        }

        [Then(@"Popular servises moved right on one position")]
        public void ThenPopularServisesMovedRightOnOnePosition()
        {
            _popularServisesFromMainMenu.MovedToTheRight();
        }

        [Then(@"Popular servises moved left on one position")]
        public void ThenPopularServisesMovedLeftOnOnePosition()
        {
            _popularServisesFromMainMenu.MovedToTheLeft();
        }

        [Then(@"Popular services moved right on one position\.")]
        public void ThenPopularServicesMovedRightOnOnePosition_()
        {
            _popularServisesFromMainMenu.MovedToTheRight();
        }

        [Then(@"Popular services moved left on one position\.")]
        public void ThenPopularServicesMovedLeftOnOnePosition_()
        {
            _popularServisesFromMainMenu.MovedToTheLeft();
        }
    }
}