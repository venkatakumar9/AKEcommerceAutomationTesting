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
        public static readonly By VectorMap = By.ClassName("map");

        /// <summary>
        /// CSS Selector Of Americas
        /// </summary>
        public static readonly By TheAmericas = By.CssSelector("area[alt='The Americas']");

        /// <summary>
        /// CSS Selector Of Africa
        /// </summary>
        public static readonly By Africa = By.CssSelector("area[alt='Africa']");

        /// <summary>
        /// CSS Selector Of Europe
        /// </summary>
        public static readonly By Europe = By.CssSelector("area[alt='Europe']");

        /// <summary>
        /// CSS Selector Of Asia
        /// </summary>
        public static readonly By Asia= By.CssSelector("area[alt='Asia']");

        /// <summary>
        /// CSS Selector Of Indian Ocean
        /// </summary>
        public static readonly By IndianOcean = By.CssSelector("area[alt='Indian Ocean']");

        /// <summary>
        /// CSS Selector Of Carribean
        /// </summary>
        public static readonly By Carribean = By.CssSelector("area[alt='Caribbean']");

        /// <summary>
        /// CSS Selector Of Australi and NewZealand
        /// </summary>
        public static readonly By AustraliaAndNewzealand = By.CssSelector("area[alt='Australia & New Zealand']");

         /// <summary>
        /// CSS Selector Of MiddleEast
        /// </summary>
        public static readonly By MiddleEast = By.CssSelector("area[alt='Middle East & North Africa']");

        /// <summary>
        /// CSS Selector Of Antarctica
        /// </summary>
        public static readonly By Antarctica = By.CssSelector("area[alt='Antarctica']");
        
        /// <summary>
        /// CSS Selector Of Arctic
        /// </summary>
        public static readonly By Arctic = By.CssSelector("area[alt='Arctic']");

        /// <summary>
        /// CSS Selector Of India And Himalayas
        /// </summary>
        public static readonly By IndiaandHimalayas= By.CssSelector("area[alt='India and the Himalayas']");
    }
}
