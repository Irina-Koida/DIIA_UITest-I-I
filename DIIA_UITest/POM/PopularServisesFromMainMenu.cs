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

        private readonly By _clickRightButton = By.CssSelector("[swiper_services-btn-next swiper-btn-next disabled]");
        private readonly By _clikLeftButton = By.CssSelector("[class=\"swiper_services-btn-prev swiper-btn-prev");
        private readonly By _swipeRight = By.CssSelector("[class=\"swiper-pagination-bullet swiper-pagination-bullet-active selectorgadget_selected\"");
        private readonly By _swipeLeft = By.CssSelector("[class=\"swiper-pagination-bullet swiper-pagination-bullet-active selectorgadget_selected\"");
        private readonly By _movedOneRight = By.CssSelector("[#gromadyanam > div.swiper_services-box]");
        private readonly By _movedOneLeft =By.CssSelector("[#gromadyanam > div.swiper_services-box]");
        private readonly By _cookieClose = By.CssSelector("[class=\"cookies-1_close\"]");

        public PopularServisesFromMainMenu SwipeToTheRightClick(
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
