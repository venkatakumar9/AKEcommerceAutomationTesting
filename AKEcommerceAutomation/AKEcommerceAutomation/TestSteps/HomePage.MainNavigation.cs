//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//  Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using com.sun.swing.@internal.plaf.synth.resources;
using java.io;

namespace AKEcommerceAutomation.TestSteps
{
    using Framework;
    using PageObjects;
    using NUnit.Framework;
    using System;
    using OpenQA.Selenium;
    using TechTalk.SpecFlow;
    using AKEcommerceAutomation.PageObjects.Object_Repository;

    sealed internal class MainNavigation : SeleniumTestBase
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
                homepage.GetBeInspiredPage().title();
            }

            [When(@"I Mouse Over on Destinations Link")]
            public void WhenIMouseOverOnDestinationsLink()
            {
                homepage.mouseover(HomePageElements.Destinationlink);
            }

            [Then(@"The Meganav Appears")]
            public void ThenTheMeganavAppears(Table table)
            {
                string[]continetnames = homepage.Meganav_topcontinetnames();
                for(int i=0; i<continetnames.Length;i++)
                    Assert.AreEqual(table.Rows[i]["Value"], continetnames[i]);
            }
           

            [Then(@"The Meganav bottom appears")]
            public void ThenTheMeganavBottomAppears(Table table)
            {
                string[] continetnames = homepage.Meganav_bottomcontinentnames();
                for (int i = 0; i < continetnames.Length; i++)
                    Assert.AreEqual(table.Rows[i]["Value"], continetnames[i]);
            }

            [Then(@"When I click on Destination link I reach the Destinations Page")]
            public void ThenWhenIClickOnDestinationLinkIReachTheDestinationsPage()
            {
               string title =  homepage.GetDestinationsPage().title();
                Assert.AreEqual("Destinations",title);
            }

            [Then(@"When I click on Journeys Link I reach Journeys Page")]
            public void ThenWhenIClickOnJourneysLinkIReachJourneysPage()
            {
                string title = homepage.GetJourneysPage().title();
                Assert.AreEqual("Journeys", title);
            }

            [Then(@"When I click on BeInspired Link I reach BeInspired Page")]
            public void ThenWhenIClickOnBeInspiredLinkIReachBeInspiredPage()
            {
                string title = homepage.GetBeInspiredPage().title();
                Assert.AreEqual("BeInspired", title);
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
                homepage.GetBeInspiredPage().title();
               
            }

            #endregion
        }

        [Binding]
        public class Countrylinks
        {
            private readonly HomePage homepage = new HomePage(driver);

            [Then(@"All the coutries in the continents will appear\.")]
            public void ThenAllTheCoutriesInTheContinentsWillAppear_()
            {
                string[] countryandcontinetnames = homepage.Megamenu_countrynames();
                foreach (var countryandcontinetname in countryandcontinetnames)
                {
                    Console.WriteLine(countryandcontinetname);
                }

            }
        }
    }
}
