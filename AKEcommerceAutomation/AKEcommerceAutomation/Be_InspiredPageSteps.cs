using System;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation
{
    [Binding]
    public class Be_InspiredPageSteps
    {
        [When(@"I click on BeInspired link")]
        public void WhenIClickOnBeInspiredLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Navigation appears in beinspired page")]
        public void ThenNavigationAppearsInBeinspiredPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
