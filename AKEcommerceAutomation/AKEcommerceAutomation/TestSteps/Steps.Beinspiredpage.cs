using System;
using System.Threading;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AKEcommerceAutomation.PageObjects.Object_Repository;


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
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            homePage.GetBeInspiredPage();
            beinspiredPage.GetInspirerInstructionalText();
            //Assert.IsTrue(beinspiredPage.GetInspirerInstructionalText());
            //Assert.AreEqual(beinspiredPage.GetInspirerInstructionalText());
        }

        //Inspirer Category images

        [When(@"I navigate to beinspired page")]
        public void WhenINavigateToBeinspiredPage()
        {
            homePage.GetBeInspiredPage();
            //ScenarioContext.Current.Pending();
        }

        [Then(@"inspirer category images appears")]
        public void ThenInspirerCategoryImagesAppears()
        {
            beinspiredPage.GetInspirerCategoryimagesSection();
            //ScenarioContext.Current.Pending();
        }

       //verifying inspirer images when clicked on inspirer category

        [When(@"I click on inspirer category")]
        public void WhenIClickOnInspirerCategory()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Click();
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Inspirer images should appear")]
        public void ThenInspirerImagesShouldAppear()
        {
            Assert.IsTrue(driver.FindElement(By.XPath(BeinspiredPageElements.navlinks)).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath(BeInspiredPage.backlinkininspirerimagesSection)).Displayed);
            driver.FindElement(By.XPath(BeInspiredPage.backlinkininspirerimagesSection)).Click();
            //var inspirerbackarrow = driver.FindElement(By.XPath("//div[@class = 'inspirer-back places-to-visit']/a")).Displayed;


            //ScenarioContext.Current.Pending();
        }



       }
}
