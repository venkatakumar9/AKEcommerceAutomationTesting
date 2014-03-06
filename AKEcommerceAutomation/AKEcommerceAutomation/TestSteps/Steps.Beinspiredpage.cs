using System;
using System.Threading;
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
            homePage.GetBeInspiredPage()
                .GetInspirerInstructionalText();
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

        // Delete the Inspirer Instructional text,
        // 
        [Given(@"I am on beinspired page")]
        public void GivenIAmOnBeinspiredPage()
        {
            homePage.GetBeInspiredPage();
            ScenarioContext.Current.Set(beinspiredPage);
        }

        [When(@"I close the Inspirer Instructional text")]
        public void WhenICloseTheInspirerInstructionalText()
        {
            beinspiredPage.Closeinspirertext();
            //ScenarioContext.Current.Pending();
        }

        [When(@"I delete all the cookies in the browser")]
        public void WhenIDeleteAllTheCookiesInTheBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [Then(@"Inspirer Instructional text re-appears\.")]
        public void ThenInspirerInstructionalTextRe_Appears_()
        {
            driver.Navigate().Refresh();
            //driver.WaitForPageToLoad();
            homePage.GetBeInspiredPage();
            beinspiredPage.GetInspirerInstructionalText();
            //Assert.IsTrue(beinspiredPage.GetInspirerInstructionalText());
            //Assert.AreEqual(beinspiredPage.GetInspirerInstructionalText());
        }


       }
}
