//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//  Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;


namespace AKEcommerceAutomation.TestSteps
{

    [Binding]
    public class BeInspiredSteps : SeleniumTestBase
    {
        
        public HomePage homePage;
        public BeInspiredPage beinspiredPage;

        [Given(@"I am on the AK homepage")]
        public void GivenIamontheAKHomepage()
        {
            homePage = new HomePage(driver);
            ScenarioContext.Current.Set(homePage);
        }

        [When(@"I click on BeInspired tab on homepage")]
        public void WhenIClickonbeinspiredlink()
        {
            homePage.GetBeInspiredPage();
        }

        [Then(@"Be-inspired Navigation Links displayed:")]
        public void ThenBe_InspiredNavigationLinksDisplayed(Table table)
        {
            var beinspirednavigationValues = beinspiredPage.GetBeinspiredNavigationValues();
            for (int i = 1; i <= beinspiredPage.GetBeinspiredNavigationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], beinspirednavigationValues[i]);
            }
            
        }

   }
}
