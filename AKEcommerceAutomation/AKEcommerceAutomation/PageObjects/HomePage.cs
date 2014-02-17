//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation.PageObjects
{
    using System;
    using Object_Repository;
    using OpenQA.Selenium;

  
   // Cliking on all the Links of the HomePage and Verifies the Elements of the HomePage.
    public class HomePage : BasePage
    {
        //Actions builder = new Actions(driver);
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }
       
        public DestinationsPage GetDestinationsPage()
        {
            _driver.FindElement(HomePageElements.Destinationlink).Click();
            return new DestinationsPage(_driver);
        }

        public JourneysPage GetJourneysPage()
        {
            _driver.FindElement(HomePageElements.JourneysLink).Click();
            return new JourneysPage(_driver);
        }

       
        public bool VerifyHomepageCarouselMainImage()
        {
            return _driver.FindElement(HomePageElements.HomepageCarouselMainImage).Displayed;
        }

       
        public BeInspired GetBeInspiredPage()
        {
            _driver.FindElement(HomePageElements.BeInspiredLink).Click();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return new BeInspired(_driver);
        }
    }
}