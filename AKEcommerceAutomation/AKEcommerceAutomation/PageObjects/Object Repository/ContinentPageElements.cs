//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------


namespace AKEcommerceAutomation.PageObjects.Object_Repository
{

    using OpenQA.Selenium;

    public class ContinentPageElements
    {
        /// <summary>
        /// Africa continennt navigation link
        /// </summary>
        public static By Navigation = By.CssSelector("[class='page-nav'] li a");
            
        /// <summary>
        /// Africa continennt Vector map
        /// </summary>
        public static By Africacontinentmap = By.Id("Content_T7A9807F6015_Col00");

        /// <summary>
        /// CSS Selector of SouthAfrica
        /// </summary>
        public static By southAfrica = By.CssSelector("area[alt='South Africa']");

    }
}
