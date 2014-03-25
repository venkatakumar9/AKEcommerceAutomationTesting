//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//  Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation
{
    [Binding]
    public class BotswanaCountryPageSteps : SeleniumTestBase
    {
        [Given(@"I reach the Botswana Page")]
        public void GivenIReachTheBotswanaPage()
        {
            new ContinentPagesSteps().GivenIReachAfricaContinentPage();
            new ContinentPagesSteps().WhenIClickOnTheCountriesLink();
            new AfricaContinentpageSteps().WhenIClickOnTheCountryImage();
            Assert.AreEqual(driver.Title, CountryPageElements.BotswanaTitle);
        }

        [Then(@"The Navigation Links are present")]
        public void ThenTheNavigationLinksArePresent(Table table)
        {
            string[] navlinks = new ContinentPage(driver).continentnavlinks();
            for (int i = 0; i < navlinks.Count(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], navlinks[i]);
            }
        }

        [When(@"I click on the overview tab")]
        public void WhenIClickOnTheOverviewTab()
        {
            driver.FindElement(By.LinkText("OVERVIEW")).Click();
        }

        [Then(@"the map is present")]
        public void ThenTheMapIsPresent()
        {
            driver.FindElement(CountryPageElements.Enquirebutton);
        }
    }

    [Binding]
    public class BotswanaHeroImage : SeleniumTestBase
    {
        private string imageurl;

        [Given(@"There is a country image in the continent page")]
        public void GivenThereIsACountryImageInTheContinentPage()
        {
            new ContinentPagesSteps().GivenIReachAfricaContinentPage();
            new ContinentPagesSteps().WhenIClickOnTheCountriesLink();
            string image = driver.FindElement(ContinentPageElements.CountryImages).GetAttribute("style");
            string[] strings = image.Split('"');
            imageurl = strings[1];
        }

        [When(@"I reach the Botswana Page")]
        public void WhenIReachTheBotswanaPage()
        {
            new AfricaContinentpageSteps().WhenIClickOnTheCountryImage();
            Assert.AreEqual(driver.Title, CountryPageElements.BotswanaTitle);
        }

        [Then(@"the Hero image is present")]
        public void ThenTheHeroImageIsPresent()
        {
            string attribute = driver.FindElement(
                By.XPath("//section[@id='carousel_a2e2e62ce3356b7093c7ff0000a0f14c']/article/div/img"))
                .GetAttribute("src");
            string[] imageur = imageurl.Split('?');
            string[] attr = attribute.Split('?');
            Assert.AreEqual(imageur[0], attr[0]);
        }
    }

    [Binding]
    public class BotswanaAreaTab : SeleniumTestBase
    {
        [When(@"I Click on AREAS")]
        public void WhenIClickOnAREAS()
        {
            driver.FindElement(By.LinkText("AREAS")).Click();
        }

        [Then(@"All the Areas with offers are available")]
        public void ThenAllTheAreasWithOffersAreAvailable()
        {
            string[] areas = new ContinentPage(driver).countries();
            if (areas[1] == null)
            {
                Console.WriteLine("No data available");
            }
            else
            {
                foreach (string area in areas)
                {
                    Console.WriteLine(area);
                }
            }
        }
    }

    [Binding]
    public class BotwswanaGGJTab : SeleniumTestBase
    {
        [When(@"I click on Guided Group journeys")]
        public void WhenIClickOnGuidedGroupJourneys()
        {
            driver.FindElement(By.LinkText("GUIDED GROUP JOURNEYS")).Click();
        }

        [Then(@"All the Guided Group Journeys with offers are Appeared")]
        public void ThenAllTheGuidedGroupJourneysWithOffersAreAppeared()
        {
            new BotswanaAreaTab().ThenAllTheAreasWithOffersAreAvailable();
        }
    }

    [Binding]
    public class BotswanaTGJtab : SeleniumTestBase
    {
        [When(@"I click on Tailor Made Journeys")]
        public void WhenIClickOnTailorMadeJourneys()
        {
            driver.FindElement(By.LinkText("TAILOR MADE JOURNEYS")).Click();
        }

        [Then(@"All the Taiolor made Journeys with offers are appeared")]
        public void ThenAllTheTaiolorMadeJourneysWithOffersAreAppeared()
        {
            new BotswanaAreaTab().ThenAllTheAreasWithOffersAreAvailable();
        }
    }

    [Binding]
    public class BotswanaAccmtab : SeleniumTestBase
    {
        [When(@"I Click on Accomodations")]
        public void WhenIClickOnAccomodations()
        {
            driver.FindElement(By.LinkText("ACCOMMODATIONS")).Click();
        }

        [Then(@"I can view all the Accomodations available")]
        public void ThenICanViewAllTheAccomodationsAvailable()
        {
            new BotswanaAreaTab().ThenAllTheAreasWithOffersAreAvailable();
        }
    }

    [Binding]
    public class BotswanaInsidertab : SeleniumTestBase
    {
        [When(@"I click on Insider Access")]
        public void WhenIClickOnInsiderAccess()
        {
            driver.FindElement(By.LinkText("INSIDER ACCESS")).Click();
        }

        [Then(@"Enquire button is present")]
        public void ThenEnquireButtonIsPresent()
        {
            string enquire = driver.FindElement(CountryPageElements.Enquirebutton).Text;
            Assert.AreEqual("ENQUIRE", enquire);
        }
    }

    [Binding]
    public class BotswanaUsefultab : SeleniumTestBase
    {
        [When(@"I click on useful info")]
        public void WhenIClickOnUsefulInfo()
        {
            driver.FindElement(By.LinkText("INSIDER ACCESS")).Click();
        }

        [Then(@"Enquire, Print buttons are present")]
        public void ThenEnquirePrintButtonsArePresent()
        {
            string enquire = driver.FindElement(CountryPageElements.Enquirebutton).Text;
            Assert.AreEqual("ENQUIRE", enquire);
            try
            {
                driver.FindElement(CountryPageElements.PrintButton);
                Console.WriteLine("Print Buttton is Present");
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }

    }
}