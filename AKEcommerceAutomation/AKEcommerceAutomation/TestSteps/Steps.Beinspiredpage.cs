using System;
using System.Collections.Generic;
using System.Linq;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.TestSteps
{
    [Binding]
    public class BeInspiredSteps : SeleniumTestBase
    {
        private readonly BeInspiredPage beinspiredPage = new BeInspiredPage(driver);
        private readonly HomePage homePage = new HomePage(driver);
        private readonly BeInspired_inspirerpage inspirerimagespage = new BeInspired_inspirerpage(driver);


        /// <summary>
        /// Verifying the navigation in Be-inspired page
        /// </summary>

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
            string[] beinspirednavigationValues = beinspiredPage.GetBeinspiredNavigationValues();
            for (int i = 0; i < beinspiredPage.GetBeinspiredNavigationCount(); i++)
            {
                Assert.AreEqual(table.Rows[i]["Value"], beinspirednavigationValues[i]);
            }
        }
        ///<summary>
        /// Delete the Inspirer Instructional text and cookies to re-enable the Inspirer Instructional text and Verifying the Footer Links
        /// </summary>

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
            beinspiredPage.GetPreFooter_CountryLinks();
            beinspiredPage.GetPreFooter_QuickLinks();
            beinspiredPage.GetPreFooter_SignUpforenews();
            beinspiredPage.GetPreFooter_Sociallinks();
            beinspiredPage.GetRightHandSideBar();
            beinspiredPage.FooterLinks();
            Assert.AreEqual(BasePage.CopyRightText, beinspiredPage.GetCopyRightText());
        }
    ///<summary>
    ///Inspirer Category images
    /// </summary>

        [When(@"I navigate to beinspired page")]
        public void WhenINavigateToBeinspiredPage()
        {
            homePage.GetBeInspiredPage();
            
        }

        [Then(@"inspirer category images appears")]
        public void ThenInspirerCategoryImagesAppears()
        {
            beinspiredPage.GetInspirerCategoryimagesSection();
        }
   
        
    ///<summary>
   ///verifying inspirer images when clicked on Places TO Vist inspirer category
   /// </summary>

        [When(@"I click on Places to visit inspirer category")]
        public void WhenIClickOnPlacesToVisitInspirerCategory()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            Assert.AreEqual("MOUNTAINS AND HIGHLANDS",
                driver.FindElement(
                    By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Text);
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span"))
                .Click();
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

  
    /// <summary>
   ///verifying inspirer images when clicked on Things To See & Do inspirer category
   /// </summary>

        [When(@"I click on THINGS TO SEE AND DO inspirer category")]
        public void WhenIClickOnTHINGSTOSEEANDDOInspirerCategory()
        {
            homePage.GetBeInspiredPage();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[5]/div/a[2]")).Click();
            //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.Name("People & Culture"))));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Assert.AreEqual("PEOPLE & CULTURE",
                driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span"))
                    .Text);
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span"))
                .Click();
        }

        [Then(@"Inspirer images appear")]
        public void ThenInspirerImagesAppear()
        {
            Assert.IsTrue(driver.FindElement(By.XPath(BeinspiredPageElements.navlinks)).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath(BeInspiredPage.inspirerbackthingstosee)).Displayed);
            Assert.AreEqual("PEOPLE & CULTURE",
                driver.FindElement(
                    By.XPath("//*[@id='infiniteScrollItem']/article/section[1]/div[1]/div[1]/div[1]/div/a/h2")).Text);
            int y = new BeInspiredPage(driver).GetInspirerImages_Category();
            driver.FindElement(By.XPath(BeInspiredPage.inspirerbackthingstosee)).Click();
        }

        /// <summary>
        ///verifying inspirer images when clicked on Where To Stay inspirer category
        /// </summary>

        [When(@"I click on where to stay inspirer category")]
        public void WhenIClickOnWhereToStayInspirerCategory()
        {
            homePage.GetBeInspiredPage();
            //driver.WaitForPageToLoad();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[5]/div/a[3]")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Assert.AreEqual("HOTELS",
                driver.FindElement(
                    By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span")).Text);
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div[1]/div/section/article/a/span[2]/span"))
                .Click();
        }

        [Then(@"where to stay inspirer images displays")]
        public void ThenWhereToStayInspirerImagesDisplays()
        {
            Assert.IsTrue(driver.FindElement(By.XPath(BeinspiredPageElements.navlinks)).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath(BeInspiredPage.inspirerbackwheretostay)).Displayed);
            Assert.AreEqual("HOTELS",
                driver.FindElement(
                    By.XPath("//*[@id='infiniteScrollItem']/article/section/div[1]/div[1]/div[1]/div/a/h2")).Text);
            int y = new BeInspiredPage(driver).GetInspirerImages_Category();
            driver.FindElement(By.XPath(BeInspiredPage.inspirerbackwheretostay)).Click();
        }

 ///  <summary>
 ///   Verifying the pinboard count in Mypinboard and in Right Hand Side Bar when user adds any image to Pinboard.
 ///  </summary>
       

        [When(@"I add an image to my pinboard")]
        public void WhenIAddAnImageToMyPinboard()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(
                ExpectedConditions.ElementExists(
                    By.XPath("//div[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span"))).Click();
            homePage.mouseover(By.Id("inspirerImagePin-d91ff12c-e335-6b70-93c7-ff0000a0f14c"));
            driver.FindElement(By.Id("inspirerImagePin-d91ff12c-e335-6b70-93c7-ff0000a0f14c")).Click();
        }

        [Then(@"Pinboard count appears on My Pinboard and on Right Hand Bar")]
        public void ThenPinboardCountAppearsOnMyPinboardAndOnRightHandBar()
        {
            int PinboardCount_MyPinboard =
                driver.FindElements(By.XPath("//*[@id='page-wrapper']/div[5]/div/a[4]/span")).Count;
            int PinboardCount_RighthandBar =
                driver.FindElements(By.XPath("//*[@id='page-wrapper']/div[1]/ul/li[5]/a/span[3]")).Count;
            Assert.AreEqual(PinboardCount_MyPinboard.ToString(), PinboardCount_RighthandBar.ToString());
            if (PinboardCount_MyPinboard == PinboardCount_RighthandBar)
            {
                Console.WriteLine(true);
                Console.WriteLine(PinboardCount_MyPinboard);
                Console.WriteLine(PinboardCount_RighthandBar);
            }
            else
            {
                Console.WriteLine(false);
            }

            }

        
  /// <summary>
  /// Navigating to the Light box and verifying suggested Journeys 
  /// </summary>

        [When(@"I Click on Find Out More link on an image")]
        public void WhenIClickOnFindOutMoreLinkOnAnImage()
        {
            homePage.GetBeInspiredPage().GetInspirerCategoryimagesSection();
            inspirerimagespage.GetInspirerimagespage();
            string str1 = driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/article/section[1]/div[1]/div[1]/div[2]/div/section/article/span[2]")).Text;
            homePage.mouseover(By.XPath("//*[@id='infiniteScrollItem']/article/section[1]/div[1]/div[1]/div[2]/div/section/article/div[1]/img"));
            driver.FindElement(By.LinkText("FIND OUT MORE")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            var clickedimage = driver.FindElement(By.XPath("//div[@id = 'about']/div/h1")).Text;
            Console.WriteLine(clickedimage, str1);
        }

        [Then(@"Light box appears with Suggested Journeys")]
        public void ThenLightBoxAppearsWithSuggestedJourneys()
        {
            var lightboxnav = driver.FindElement(By.XPath("//div[@class = 'inner-popup-top olu-tab-nav nav']")).Displayed;
            driver.FindElement(By.XPath("//article[@class = 'popup-overlay']/div/div/a[2]")).Click();
            inspirerimagespage.GetGuidedGroupJourneys_SuggestedJourneysinlightbox();
            inspirerimagespage.GetguidedGroupJourneys_Section();
            Console.WriteLine("-----------------------------------");
            inspirerimagespage.GetTailorMadeJourneys_Section();
            inspirerimagespage.GetTailorMadeJourneys_SuggestedJourneysinlightbox();
            inspirerimagespage.CloseLightBox();
        }

        /// <summary>
        /// Verifying MyPinboard toolbar links.
        /// </summary>     
        
        [When(@"I click on MyPinboard Page")]
        public void WhenIClickOnMyPinboardPage()
        {
            homePage.GetBeInspiredPage().GetMyPinboard();

        }

        [Then(@"MyPinboard toolbar links appears")]
        public void ThenMyPinboardToolbarLinksAppears()
        {
            beinspiredPage.GetMyPinboard_NavLinks();
        }


        /// <summary>
        /// Delete images in my pinboard
        /// </summary>

        [When(@"I Navigate to Mypinboard")]
        public void WhenINavigateToMypinboard()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            beinspiredPage.GetInspirerCategoryimagesSection();
            inspirerimagespage.GetInspirerimagespage();
            homePage.mouseover(By.XPath("//*[@id='infiniteScrollItem']/article/section[1]/div[2]/div[1]/div/div/section/article/div[1]"));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            string str1 =
               driver.FindElement(
                   By.XPath(
                       "//*[@id='infiniteScrollItem']/article/section[1]/div[2]/div[1]/div/div/section/article/span[2]/span"))
                   .Text;
            driver.FindElement(By.Id("inspirerImagePin-3108fc2c-e335-6b70-93c7-ff0000a0f14c")).Click();
            beinspiredPage.GetMyPinboard();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            homePage.mouseover(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/div/section/article/div[1]/img"));
            string pinboardedimage =
                driver.FindElement(
                    By.XPath("//*[@id='infiniteScrollItem']/div/div/div[1]/div/section/article/span[2]/span")).Text;
           Assert.AreEqual(str1, pinboardedimage);
           
        }

        [When(@"I click on delete button")]
        public void WhenIClickOnDeleteButton()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            homePage.mouseover(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/div/section/article/div[1]/img"));
            driver.FindElement(By.Id("inspirerImageUnPin-3108fc2c-e335-6b70-93c7-ff0000a0f14c")).Click();

        }

        [Then(@"Images are deleted from MyPinboard")]
        public void ThenImagesAreDeletedFromMyPinboard()
        {
            string noImages = driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/p")).Text;
            Assert.AreEqual(noImages, "No more image in your pinboard. Please pin at least one.");
            Console.WriteLine(noImages);
        }

  ///<summary>
  /// Delete entire images in Pinboard
  /// </summary>



        [When(@"I add image to my pinboard")]
        public void WhenIAddImageToMyPinboard()
        {
            homePage.GetBeInspiredPage().GetInspirerInstructionalText();
            beinspiredPage.GetInspirerCategoryimagesSection();
            inspirerimagespage.GetInspirerimagespage();
            driver.FindElement(By.XPath("//*[@id='inspirerImagePin-d91ff12c-e335-6b70-93c7-ff0000a0f14c']/a")).Click();
            driver.FindElement(By.XPath("//*[@id='inspirerImagePin-3108fc2c-e335-6b70-93c7-ff0000a0f14c']/a")).Click();
            driver.FindElement(By.XPath("//*[@id='inspirerImagePin-2108fc2c-e335-6b70-93c7-ff0000a0f14c']/a")).Click();
            beinspiredPage.GetMyPinboard();
        }

        [When(@"I click on delete button on pinboard toolbar")]
        public void WhenIClickOnDeleteButtonOnPinboardToolbar()
        {
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div[1]/div[3]/div[2]/a")).Click();
            driver.FindElement(By.Id("deletePinboardAction")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        [Then(@"Entire images are deleted from MyPinboard page")]
        public void ThenEntireImagesAreDeletedFromMyPinboardPage()
        {
           beinspiredPage.GetInspirerCategoryimagesSection();
           beinspiredPage.GetMyPinboard();
            //*** This step will be changed when the navigation changed. i.e. after deleting page should stay in MyPinboard Page with text displayed.
        }

        ///<summary>
        /// Verifying the Share Pinboard links navigating to Right pages 
        /// </summary>

        [Given(@"I am on MyPinboard page")]
        public void GivenIAmOnMyPinboardPage()
        {
            homePage.GetBeInspiredPage().GetMyPinboard();
        }

        [When(@"I Click on Share Pinboard Icons")]
        public void WhenIClickOnSharePinboardIcons()
        {
            
            driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div[1]/div[4]/a[1]/img")).Click();
            
            
        }

        [Then(@"Each Icon Navigates to right page")]
        public void ThenEachIconNavigatesToRightPage()
        {
            //driver.SwitchTo().Window();
            //ScenarioContext.Current.Pending();
        }


        
    }
}