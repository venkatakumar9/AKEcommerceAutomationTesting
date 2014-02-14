//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using AKEcommerceAutomation.PageObjects.Object_Repository;

namespace AKEcommerceAutomation.TestSteps
{
    using Framework;
    using PageObjects;
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;

    internal class MainNavigation : SeleniumTestBase
    {
        [Binding]
        public class Mainnavigation
        {
            private readonly HomePage homepage = new HomePage(driver);
            [When(@"I click on BeInspired link")]
            public void WhenIClickOnBeInspiredLink()
            {
                homepage.GetBeInspiredPage();
            }

            [Then(@"I Navigate to BeInspired Page")]
            public void ThenINavigateToBeInspiredPage()
            {
                homepage.GetBeInspiredPage().beinspiredtitle();
            }

            [When(@"I Mouse Over on Destinations Link")]
            public void WhenIMouseOverOnDestinationsLink()
            {
                homepage.mouseover(HomePageElements.Destinationlink);
            }

            [Then(@"The Meganav Appears")]
            public void ThenTheMeganavAppears()
            {
                homepage.Meganav();
              
            }

            [Then(@"When I click on Destination link I reach the Destinations Page")]
            public void ThenWhenIClickOnDestinationLinkIReachTheDestinationsPage()
            {
                ScenarioContext.Current.Pending();
            }

            [Then(@"When I click on Journeys Link I reach Journeys Page")]
            public void ThenWhenIClickOnJourneysLinkIReachJourneysPage()
            {
                ScenarioContext.Current.Pending();
            }

            [Then(@"When I click on BeInspired Link I reach BeInspired Page")]
            public void ThenWhenIClickOnBeInspiredLinkIReachBeInspiredPage()
            {
                ScenarioContext.Current.Pending();
            }
        }
        [Binding]
        public class Beisnpiredlink 
        {
            #region BeInspired Link Navigation

            private readonly HomePage homepage = new HomePage(driver);

            [When(@"I click on BeInspired link")]
            public void WhenIClickOnBeInspiredLink()
            {
                homepage.GetBeInspiredPage();
            }

            [Then(@"I Navigate to BeInspired Page")]
            public void ThenINavigateToBeInspiredPage()
            {
                homepage.GetBeInspiredPage().beinspiredtitle();
               
            }

            #endregion
        }

      

    }
}