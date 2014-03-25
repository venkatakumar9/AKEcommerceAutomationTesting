using System;
using System.IO;
using System.Linq;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using ImpromptuInterface.Build;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Assert = NUnit.Framework.Assert;

namespace AKEcommerceAutomation
{
    [Binding]
    public class ChobeAreaPageSteps : SeleniumTestBase
    {
        private string imageurl;
        [When(@"I click on Chobe")]
        public void WhenIClickOnChobe()
        {
               foreach (IWebElement country in driver.FindElements(ContinentPageElements.countries))
                {
                    if (country.Text=="CHOBE")
                    {
                        country.Click();
                        break;
                    }
                }
               
        }
        
        [Then(@"I reach Chobe area page")]
        public void ThenIReachChobeAreaPage()
        {
          Assert.AreEqual("Chobe National Park",driver.Title);
        }

        [Given(@"I reach the Chobe Area Page")]
        public void GivenIReachTheChobeAreaPage()
        {
            new BotswanaCountryPageSteps().GivenIReachTheBotswanaPage();
            new BotswanaAreaTab().WhenIClickOnAREAS();
            WhenIClickOnChobe();
        }

        [Then(@"All the navigation links appear")]
        public void ThenAllTheNavigationLinksAppear(Table table)
        {
            string[] navlinks = new ContinentPage(driver).continentnavlinks();
            for (int i = 0; i < navlinks.Count(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], navlinks[i]);
            }
        }

        [Then(@"the map is present in the overview page")]
        public void ThenTheMapIsPresentInTheOverviewPage()
        {
            driver.FindElement(CountryPageElements.mapid);
        }

        [Given(@"There is a Area image in the Country page")]
        public void GivenThereIsAAreaImageInTheCountryPage()
        {
            new BotswanaCountryPageSteps().GivenIReachTheBotswanaPage();
            new BotswanaAreaTab().WhenIClickOnAREAS();
            string image = driver.FindElement(ContinentPageElements.CountryImages).GetAttribute("style");
            string[] strings = image.Split('"');
            imageurl = strings[1];
           
        }

        [When(@"I reach the Chobe Area Page")]
        public void WhenIReachTheChobeAreaPage()
        {
            WhenIClickOnChobe();
        }

        [Then(@"the Hero image is present in area page")]
        public void ThenTheHeroImageIsPresentInAreaPage()
        {
            string attribute = driver.FindElement(
              By.XPath("//section[@id='carousel_2eaa012de3356b7093c7ff0000a0f14c']/article/div/img"))
              .GetAttribute("src");
            string[] imageur = imageurl.Split('?');
            string[] attr = attribute.Split('?');
            Assert.AreEqual(imageur[0], attr[0]);
        }
    }
}
