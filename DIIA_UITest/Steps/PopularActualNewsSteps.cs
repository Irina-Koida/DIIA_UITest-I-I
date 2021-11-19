using System;
using TechTalk.SpecFlow;

namespace DIIA_UITest.Steps
{
    [Binding]
    public class PopularActualNewsSteps
    {
        [Given(@"News page is open")]
        public void GivenNewsPageIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click ""(.*)"" button")]
        public void WhenIClickButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the first news")]
        public void WhenIClickOnTheFirstNews()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The pagination number of next page are active")]
        public void ThenThePaginationNumberOfNextPageAreActive()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate to the next page")]
        public void ThenINavigateToTheNextPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate to the previous page")]
        public void ThenINavigateToThePreviousPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I navigate to the news page")]
        public void ThenINavigateToTheNewsPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
