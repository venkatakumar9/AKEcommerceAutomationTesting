using System;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace AKEcommerceAutomation.TestSteps
{

    [Binding]
    public class BeInspiredPage : SeleniumTestBase
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
        public void ThenBeInspiredNavigationLinksDisplayed(Table table)
        {
            var beinspirednavigationValues = homePage.GetBeInspiredPage().GetBeinspiredNavigationValues();
            for (int i = 1; i <= homePage.GetBeInspiredPage().GetBeinspiredNavugationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], beinspirednavigationValues[i]);
            }
            
        }

        
    }
}
