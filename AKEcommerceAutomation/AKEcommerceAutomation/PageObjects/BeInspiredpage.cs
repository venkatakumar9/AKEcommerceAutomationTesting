using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
    public class BeInspiredPage : BasePage
    {
        //public BeInspiredPage beinspiredPage;
        public BeInspiredPage(IWebDriver driver)
            : base(driver)
        {
            //beinspiredPage = new BeInspiredPage(driver);
        }

        public string title()
        {
            return driver.Title;
        }

        public bool GetInspirerInstructionalText()
        {
            return _driver.FindElement(By.XPath("//*[@id='inspirerInstructionalText']/div/p")).Displayed;
        }

        public int GetBeinspiredNavigationCount()
        {
            return _driver.FindElements(By.XPath("//*[@id='page-wrapper']/div[5]/div/a")).Count;
        }

        public string[] GetBeinspiredNavigationValues()
        {
            var beinspirednavigationValues = new string[GetBeinspiredNavigationCount()];
            for (int i = 1; i < GetBeinspiredNavigationCount(); i++)
            {
                beinspirednavigationValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[5]/div/a[" + (i + 1) + "]")).Text;
            }
            return beinspirednavigationValues;
        }
    }
}