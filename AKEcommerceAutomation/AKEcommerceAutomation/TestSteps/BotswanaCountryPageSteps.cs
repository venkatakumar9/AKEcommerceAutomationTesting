using System;
using System.Linq;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
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
           Assert.AreEqual(driver.Title,CountryPageElements.BotswanaTitle);
        }
        
        [Then(@"The Navigation Links are present")]
        public void ThenTheNavigationLinksArePresent(Table table)
        {
            string[] navlinks = new ContinentPage(driver).continentnavlinks();
            for (int i = 0; i < navlinks.Count() ; i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], navlinks[i]);
            }
        }
    }
}
