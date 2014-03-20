using System;
using System.Threading;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
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

       //verifying inspirer images when clicked on Places TO Vist inspirer category

        [When(@"I click on Places to visit inspirer category")]
        public void WhenIClickOnPlacesToVisitInspirerCategory()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            Assert.AreEqual("MOUNTAINS AND HIGHLANDS", driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Text);
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Click();
        }

        [Then(@"Inspirer images should appear")]
        public void ThenInspirerImagesShouldAppear()
        {

            Assert.IsTrue(driver.FindElement(By.XPath(BeinspiredPageElements.navlinks)).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath(BeInspiredPage.inspirerbackplacestovisit)).Displayed);
            Assert.AreEqual("MOUNTAINS AND HIGHLANDS",
            driver.FindElement(
                    By.XPath("//*[@id='infiniteScrollItem']/article/section[1]/div[1]/div[1]/div[1]/div/a/h2")).Text);
            int x = new BeInspiredPage(driver).GetInspirerImages_Category();
            driver.FindElement(By.XPath(BeInspiredPage.inspirerbackplacestovisit)).Click();
            beinspiredPage.GetInspirerCategoryimagesSection();
           
        }

        ////verifying inspirer images when clicked on Things To See & Do inspirer category

        [When(@"I click on THINGS TO SEE AND DO inspirer category")]
        public void WhenIClickOnTHINGSTOSEEANDDOInspirerCategory()
        {
            homePage.GetBeInspiredPage();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[5]/div/a[2]")).Click();
            //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Name("People & Culture"))));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Assert.AreEqual("PEOPLE & CULTURE", driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span")).Text);
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span")).Click();
        }

        [Then(@"Inspirer images appear")]
        public void ThenInspirerImagesAppear()
        {
            Assert.IsTrue(driver.FindElement(By.XPath(BeinspiredPageElements.navlinks)).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath(BeInspiredPage.inspirerbackthingstosee)).Displayed);
            Assert.AreEqual("PEOPLE & CULTURE", driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/article/section[1]/div[1]/div[1]/div[1]/div/a/h2")).Text);
            int y = new BeInspiredPage(driver).GetInspirerImages_Category();
            driver.FindElement(By.XPath(BeInspiredPage.inspirerbackthingstosee)).Click();
        }

        //verifying inspirer images when clicked on Where To Stay inspirer category

        [When(@"I click on where to stay inspirer category")]
        public void WhenIClickOnWhereToStayInspirerCategory()
        {
            homePage.GetBeInspiredPage();
            //driver.WaitForPageToLoad();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[5]/div/a[3]")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Assert.AreEqual("HOTELS", driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Text);
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Click();
        }
  
        [Then(@"where to stay inspirer images displays")]
        public void ThenWhereToStayInspirerImagesDisplays()
        {
            Assert.IsTrue(driver.FindElement(By.XPath(BeinspiredPageElements.navlinks)).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath(BeInspiredPage.inspirerbackwheretostay)).Displayed);
            Assert.AreEqual("HOTELS", driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/article/section/div[1]/div[1]/div[1]/div/a/h2")).Text);
            int y = new BeInspiredPage(driver).GetInspirerImages_Category();
            driver.FindElement(By.XPath(BeInspiredPage.inspirerbackwheretostay)).Click();
        }

        //Verifying the pinboard count in Mypinboard and in Right Hand Side Bar when user adds any image to Pinboard.

        [When(@"I add an image to my pinboard")]
        public void WhenIAddAnImageToMyPinboard()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span"))).Click();
            homePage.mouseover(By.Id("inspirerImagePin-d91ff12c-e335-6b70-93c7-ff0000a0f14c"));
            driver.FindElement(By.Id("inspirerImagePin-d91ff12c-e335-6b70-93c7-ff0000a0f14c")).Click();

        }

        [Then(@"Pinboard count appears on My Pinboard and on Right Hand Bar")]
        public void ThenPinboardCountAppearsOnMyPinboardAndOnRightHandBar()
        {
            int PinboardCount = driver.FindElements(By.XPath("//span[@class = 'nav-count-wrapper']")).Count;
            Assert.AreEqual(PinboardCount, driver.FindElement(By.XPath("//span[@class = 'sidePinboardValue nav-count']")).Text);
            //ScenarioContext.Current.Pending();
        }

        
       }

}
