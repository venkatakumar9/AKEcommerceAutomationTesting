﻿using System;
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
            driver.FindElement(CountryPageElements.mapid);
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
            if (areas != null)
            {
                    foreach (var area in areas)
                    {
                        Console.WriteLine(area);
                    }
                
            }
            else
            {
                Console.WriteLine("No Areas in Country page");
            }
        }

    }

}