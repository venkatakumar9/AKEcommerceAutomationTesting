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
    public class BeInspiredSteps : SeleniumTestBase
    {
        
       
        HomePage homePage = new HomePage(driver);
        BeInspiredPage beinspiredPage= new BeInspiredPage(driver);

        [Given(@"I am on the AK homepage")]
        public void GivenIamontheAKHomepage()
        {
            
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
            for (int i = 0; i < beinspiredPage.GetBeinspiredNavigationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], beinspirednavigationValues[i]);
            }
            
        }


       }
}
