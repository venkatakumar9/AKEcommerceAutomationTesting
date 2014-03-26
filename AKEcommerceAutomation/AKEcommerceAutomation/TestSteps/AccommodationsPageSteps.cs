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
    public class AccommodationsPageSteps : SeleniumTestBase
    {
        [Given(@"I reach the Chobe Area page")]
        public void GivenIReachTheChobeAreaPage()
        {
            new BotswanaAreaTab().WhenIClickOnAREAS();
            new ChobeAreaPageSteps().WhenIClickOnChobe();
        }
        
        [When(@"I click on Accommodations tab")]
        public void WhenIClickOnAccommodationsTab()
        {
            string[] navlinks = new ContinentPage(driver).navlinks();
            foreach (var navlink in navlinks)
            {
                if (navlink=="ACCOMMODATIONS")
                {
                    driver.FindElement(By.LinkText(navlink)).Click();
                }
                
            }
        }
        
        [When(@"I click on Sanctuary Chobe Chilwero")]
        public void WhenIClickOnSanctuaryChobeChilwero()
        {
            
             foreach (IWebElement accomodation in driver.FindElements(ContinentPageElements.countries))
                {
                    if (accomodation.Text == "SANCTUARY CHOBE CHILWERO-CHOBE")
                    {
                        accomodation.Click();
                        break;
                    }
                }
        }

        [Then(@"All the Avialable Accomodatioons are present")]
        public void ThenAllTheAvialableAccomodatioonsArePresent()
        {
            string[] accomodations= new ContinentPage(driver).carouseltexts();
            foreach (var accomodation in accomodations)
            {
                Console.WriteLine(accomodation);
            }
        }

        [Then(@"I reach Sanctuary Chobe Chilwero Accomodation page")]
        public void ThenIReachSanctuaryChobeChilweroAccomodationPage()
        {
            Assert.AreEqual("Sanctuary Chobe Chilwero Lodge, Chobe", driver.Title);
        }
    }
}
