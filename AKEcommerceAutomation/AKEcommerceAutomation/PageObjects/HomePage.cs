using AKEcommerceAutomation.Framework;
using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
    public class HomePage : BasePage
    {
        public const string HomepageCarouselMainImage = "//div[@id = 'Content_C002_Col00']/section";
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
    }
}