using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIIA_UITest.POM
{
    class ServiceSwiperPage
    {
        private readonly IWebDriver _webDriver;

        public ServiceSwiperPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private readonly By _card = By.XPath("//*[@id='gromadyanam']//*[@class = 'swiper_services-slide-title']/text()");

        public ServiceSwiperPage GoToServiceSwiperPage()
        {
            _webDriver.Navigate().GoToUrl("https://diia.gov.ua/");
            return this;
        }

    }
}
