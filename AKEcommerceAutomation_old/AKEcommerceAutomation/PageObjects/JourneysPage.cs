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