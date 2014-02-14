//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using java.net;
using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects.Object_Repository
{
    /// <summary>
    ///     This is the object reposiroty of the HomePage Elements
    /// </summary>
    public static class HomePageElements
    {
        /// <summary>
        /// Destination Link
        /// </summary>
        public static By Destinationlink = By.XPath("//*[@id='destinations-hub']");

        /// <summary>
        ///  Journeys Link
        /// </summary>
        public static By JourneysLink = By.XPath("//*[@id='journeys']");

        /// <summary>
        /// HomePage Image Carousels
        /// </summary>
        public static By HomepageCarouselMainImage = By.XPath("//div[@id='Content_C002_Col00']/section");

        /// <summary>
        /// BeInpired link
        /// </summary>
        public static By BeInspiredLink = By.Id("when-to-go");

        /// <summary>
        /// Top Mega Nav links
        /// </summary>
        public static By Meganavmenutop = By.CssSelector("[class='m-menu-top'] li [class='header-10'] a");

        /// <summary>
        /// Bottom Mega Nav links
        /// </summary>
        public static By Meganavmenubottom = By.Id("[class='m-menu-bottom'] li [class='header-10'] a");
    }
}