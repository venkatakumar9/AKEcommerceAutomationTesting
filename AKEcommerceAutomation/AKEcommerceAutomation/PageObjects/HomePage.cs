//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using OpenQA.Selenium.Interactions;

namespace AKEcommerceAutomation.PageObjects
{
    using System;
    using Object_Repository;
    using OpenQA.Selenium;

    /// <summary>
    ///     Cliking on all the Links of the HomePage and Verifies the Elements of the HomePage.
    /// </summary>
    public class HomePage : BasePage
    {
        //Actions builder = new Actions(driver);
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        /// <summary>
        ///     Clicking on Destination Link
        /// </summary>
        public DestinationsPage GetDestinationsPage()
        {
            _driver.FindElement(HomePageElements.Destinationlink).Click();
            return new DestinationsPage(_driver);
        }

        /// <summary>
        ///     Clicking on Journey Link
        /// </summary>
        public JourneysPage GetJourneysPage()
        {
          

            _driver.FindElement(HomePageElements.JourneysLink).Click();
            return new JourneysPage(_driver);
        }

        /// <summary>
        ///     verifying the HomePage Image carousel.
        /// </summary>
        public bool VerifyHomepageCarouselMainImage()
        {
            return _driver.FindElement(HomePageElements.HomepageCarouselMainImage).Displayed;
        }

        /// <summary>
        ///     Clicking on BeInspired Link
        /// </summary>
        public BeInspired GetBeInspiredPage()
        {
            _driver.FindElement(HomePageElements.BeInspiredLink).Click();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return new BeInspired(_driver);
        }
    }
}