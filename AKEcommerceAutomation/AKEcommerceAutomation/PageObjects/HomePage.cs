using System;
using AKEcommerceAutomation.Framework;
using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
    public class HomePage : BasePage
    {
        public const string HomepageCarouselMainImage = "//div[@class = 'sf_colsOut sf_1col_1_100']/div/section";
        //Actions builder = new Actions(driver);
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public DestinationsPage GetDestinationsPage()
        {
            _driver.FindElement(By.XPath("//*[@id='destinations-hub']")).Click();
            //_driver.WaitForPageToLoad();
            return new DestinationsPage(_driver);
        }

        public JourneysPage GetJourneysPage()
        {
            _driver.FindElement(By.XPath("//*[@id='journeys']")).Click();
            return new JourneysPage(_driver);
        }

        public bool VerifyHomepageCarouselMainImage()
        {
            return _driver.FindElement(By.XPath("//div[@id = 'Content_C002_Col00']/section")).Displayed;
        }

        public string GetHomepagemiddle_sectionText()
        {
           return driver.FindElement(By.XPath("//*[@id='Footer_C019_Col00']/div/div")).Text;
        }

        public bool GetGetHomePageMiddle_Section()
        {
            return _driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[6]")).Displayed;
        }

        public string GetGuidedgroupjourneys_Homepage()
        {
           return driver.FindElement(By.XPath("//*[@id='Footer_C021_Col00']/h3")).Text;
        }

        public bool GetGuidedGroupJourneysInHomepage_Section()
        {
            return _driver.FindElement(By.XPath("//div[@id='footer']/div[4]")).Displayed;
        }

        public string GetTailormadejourneys_Homepage()
        {
            return driver.FindElement(By.XPath("//*[@id='Footer_C023_Col00']/h3")).Text;
        }

        public bool GetTailorMadeJourneysInHomepage_Section()
        {
            return _driver.FindElement(By.XPath("//div[@id='footer']/div[6]")).Displayed;
        }

        
    }
}