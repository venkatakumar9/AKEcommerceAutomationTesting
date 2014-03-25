//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.PageObjects.Object_Repository
{
    public static class CountryPageElements
    {
        /// <summary>
        /// Title of the Page
        /// </summary>
        public static string BotswanaTitle = "Botswana Safari, Botswana Holiday - A&amp;K";

        /// <summary>
        /// ID of the map
        /// </summary>
        public static readonly By mapid = By.Id("map_canvas");

        /// <summary>
        /// Enquire button 
        /// </summary>
        public static readonly By Enquirebutton = By.CssSelector("div.pageTabRenderArea > section.top-cta-panel > a.button-secondary");

        /// <summary>
        /// Print button 
        /// </summary>
        public static readonly By PrintButton = By.ClassName("cta-print");
    }
}