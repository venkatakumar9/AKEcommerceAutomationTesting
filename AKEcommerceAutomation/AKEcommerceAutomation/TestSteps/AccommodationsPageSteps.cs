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
        [Given(@"I reach the Accomodation page")]
        public void GivenIReachTheAccomodationPage()
        {
            new BotswanaCountryPageSteps().GivenIReachTheBotswanaPage();
            new ChobeAreaPageSteps().GivenIReachTheChobeAreaPage();
            new AccommodationsPageSteps().WhenIClickOnAccommodationsTab();
            new AccommodationsPageSteps().WhenIClickOnSanctuaryChobeChilwero();
            
        }

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
                    if (accomodation.Text == "SANCTUARY CHOBE CHILWERO LODGE, CHOBE")
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

    [Binding]
    public class AccomodationsHeroImage : SeleniumTestBase
    {
        private string imageurl;
        [Given(@"There is a Accomodation image in the Area page")]
        public void GivenThereIsAAccomodationImageInTheAreaPage()
        {
           new BotswanaCountryPageSteps().GivenIReachTheBotswanaPage();
           new ChobeAreaPageSteps().GivenIReachTheChobeAreaPage();
           new AccommodationsPageSteps().WhenIClickOnAccommodationsTab();
           string image = driver.FindElement(ContinentPageElements.CountryImages).GetAttribute("style");
           string[] strings = image.Split('"');
           imageurl = strings[1];
        }

        [When(@"I reach the Accomodation page")]
        public void WhenIReachTheAccomodationPage()
        {
            new AccommodationsPageSteps().WhenIClickOnSanctuaryChobeChilwero();
        }

        [Then(@"the Hero image is present in accomodation page")]
        public void ThenTheHeroImageIsPresentInAccomodationPage()
        {
            string attribute = driver.FindElement(
               By.XPath("//*[@id='carousel_5a87072de3356b7093c7ff0000a0f14c']/article/div/img"))
               .GetAttribute("src");
            string[] imageur = imageurl.Split('?');
            string[] attr = attribute.Split('?');
            Assert.AreEqual(imageur[0], attr[0]);
        }

    }
}
