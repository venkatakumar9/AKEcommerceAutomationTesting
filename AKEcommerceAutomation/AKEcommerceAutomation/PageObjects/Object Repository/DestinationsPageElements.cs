//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation.PageObjects.Object_Repository
{
    using OpenQA.Selenium;

    public static class DestinationsPageElements
    {
         /// <summary>
        /// CSS Selector Of Vector map
        /// </summary>
        public static readonly By VectorMap = By.CssSelector("img.map-overlay");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By TheAmericas = By.CssSelector("area[alt='The Americas']");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By Africa = By.CssSelector("area[alt='Africa']");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By Europe = By.CssSelector("area[alt='Europe']");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By Asia= By.CssSelector("area[alt='Asia']");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By IndianOcean = By.CssSelector("area[alt='Indian Ocean']");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By Carribean = By.CssSelector("area[alt='Caribbean']");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By AustraliaAndNewzealand = By.CssSelector("area[alt='Australia & New Zealand']");
    }
}
