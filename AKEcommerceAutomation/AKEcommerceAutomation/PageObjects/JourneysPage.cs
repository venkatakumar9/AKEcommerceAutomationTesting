//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//  Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
    public class JourneysPage : BasePage
    {
        public JourneysPage(IWebDriver driver) : base(driver)
        {
        }

        public string title()
        {
            return driver.Title;
        }
    }
}