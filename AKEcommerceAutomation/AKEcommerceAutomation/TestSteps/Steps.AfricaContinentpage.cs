//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation
{
    [Binding]
    public class AfricaContinentpageSteps : SeleniumTestBase
    {
        [When(@"I click on the country image")]
        public void WhenIClickOnTheCountryImage()
        {
                foreach (IWebElement country in driver.FindElements(ContinentPageElements.countries))
                {
                    try
                    {
                        country.Click();
                        string title = driver.Title;
                        Console.WriteLine(title);
                        break;
                    }
                    catch (Exception ex)
                    {
                        string e = ex.ToString();
                    }
                
            }
        }

        [Then(@"I reach the specific country page")]
        public void ThenIReachTheSpecificCountryPage()
        {
            Assert.AreEqual("Botswana", driver.Title);
        }

        [When(@"I click on Guided Group Journey Link")]
        public void WhenIClickOnGuidedGroupJourneyLink()
        {
            driver.FindElement(By.LinkText("GUIDED GROUP JOURNEYS")).Click();
        }

        [Then(@"All the Guided Group Journeys Appear")]
        public void ThenAllTheGuidedGroupJourneysAppear()
        {
            var homePage = new HomePage(driver);
            var packages = homePage.GetContinentPage().carouseltexts();
            foreach (var package in packages)
            {
                Console.WriteLine(package);
            }
        }

        [When(@"I click on Guided Group Journey")]
        public void WhenIClickOnGuidedGroupJourney()
        {
            WhenIClickOnTheCountryImage();
           
        }

        [Then(@"I reach the Guided Group Journey Page")]
        public void ThenIReachTheGuidedGroupJourneyPage()
        {
            Assert.AreEqual("Wings Over Botswana 2013 Test", driver.Title);
        }
    }
}