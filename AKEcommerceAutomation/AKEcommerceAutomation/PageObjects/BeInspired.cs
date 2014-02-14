using AKEcommerceAutomation.PageObjects.Object_Repository;
using OpenQA.Selenium;
using  NUnit.Framework;

namespace AKEcommerceAutomation.PageObjects
{
    public class BeInspired : BasePage
    {
        public BeInspired(IWebDriver driver) : base(driver)
        {
            
        }

        public void beinspiredtitle()
        {
           Assert.AreEqual(BeinspiredPageElements.BeInspiredTitle, driver.Title);
        }
    }
}