using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DIIA_UITest.Steps
{
    [Binding]

    public sealed class GoToFaqPage
    {
        [When(@"I move to '(.*)' block")]

        public void WhenIMoveToBlock(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on '(.*)' button")]
        public void WhenIClickOnButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I navigate to the FAQ Page with Faq Header text")]
        public void ThenINavigateToTheFAQPageWithFaqHeaderText()
        {
            ScenarioContext.Current.Pending();
        }



        private readonly ScenarioContext _scenarioContext;

        public GoToFaqPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        }
    }
