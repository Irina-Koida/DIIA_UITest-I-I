using OpenQA.Selenium;

namespace DIIA_UITest.POM
{
    class PopularServisesFromMainMenu
    {
        private readonly IWebDriver _webDriver;

        public PopularServisesFromMainMenu(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _clickRightButton = By.CssSelector("");
        private readonly By _clikLeftButton = By.CssSelector("");
        private readonly By _swipeRight = By.XPath("");
        private readonly By _swipeLeft = By.XPath("");
        private readonly By _movedOneRight = By.XPath("");
        private readonly By _movedOneLeft = By.XPath("");
        private readonly By _cookieClose = By.CssSelector("[class = 'cookies-1_close']");

        public PopularServisesFromMainMenu SwipeToTheRightClick()
        {
            _webDriver.FindElement(_swipeRight).Click();
            return this;
        }

        public PopularServisesFromMainMenu SwipeToTheLeftClick()
        {
            _webDriver.FindElement(_swipeRight).Click();
            _webDriver.FindElement(_swipeLeft).Click();
            _webDriver.FindElement(_cookieClose).Click();
            return this;
        }

        public PopularServisesFromMainMenu ClickToTheRightSide()
        {
            _webDriver.FindElement(_clickRightButton).Click();
            return this;
        }

        public PopularServisesFromMainMenu ClickToTheLeftSide()
        {
            _webDriver.FindElement(_clickRightButton).Click();
            _webDriver.FindElement(_clikLeftButton).Click();
            _webDriver.FindElement(_cookieClose).Click();
            return this;
        }

        public PopularServisesFromMainMenu GoToPopularServicePage()
        {
            _webDriver.Navigate().GoToUrl("");
            return this;
        }

        public void MovedToTheRight()
        {
            _webDriver.FindElement(_movedOneRight);
        }

        public void MovedToTheLeft()
        {
            _webDriver.FindElement(_movedOneLeft);
        }
    }
}
