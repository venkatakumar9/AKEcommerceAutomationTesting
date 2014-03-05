//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

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
        public static readonly By Destinationlink = By.Id("destinations-hub");

        /// <summary>
        ///  Journeys Link
        /// </summary>
        public static readonly By JourneysLink = By.XPath("//*[@id='journeys']");

        /// <summary>
        /// HomePage Image Carousels
        /// </summary>
        public static readonly By HomepageCarouselMainImage = By.XPath("//div[@id='Content_C002_Col00']/section");

        /// <summary>
        /// BeInpired link
        /// </summary>
        public static readonly By BeInspiredLink = By.Id("when-to-go");

        /// <summary>
        /// Top Mega Nav Continent links
        /// </summary>
        public static readonly By Meganavmenutop = By.CssSelector("[class='m-menu-top'] li [class='header-10'] a");

        /// <summary>
        /// Bottom Mega Nav Continent links
        /// </summary>
        public static readonly By Meganavmenubottom = By.CssSelector("[class='m-menu-bottom'] li [class='header-10'] a");

        /// <summary>
        /// Bottom Mega Nav Country links
        /// </summary>
        public static readonly By Meganavmenu_countriesandcontinents = By.CssSelector("[class='tc'] li");
    }
}