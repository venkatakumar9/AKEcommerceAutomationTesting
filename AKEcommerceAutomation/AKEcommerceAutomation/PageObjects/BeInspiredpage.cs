using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
    public class BeInspiredpage : BasePage
    {
        public BeInspiredpage(IWebDriver driver) : base(driver)
        {
        }

        public List<BeInspired_Navigation> beinspirednavigation { get; set; }

        public string title()
        {
            return driver.Title;
        }

        public bool GetInspirerInstructionalText()
        {
            return _driver.FindElement(By.XPath("//*[@id='inspirerInstructionalText']/div/p")).Displayed;
        }

        public void GetBeinspiredNavigation()
        {
            beinspirednavigation = new List<BeInspired_Navigation>();
            int count = _driver.FindElements(By.XPath("//div[@class = 'nav']/a")).Count();

            if (count > 0)
            {
                for (int i = 1; i <= count; i++)
                {
                    beinspirednavigation.Add(new BeInspired_Navigation
                    {
                        altText = _driver.FindElement(By.XPath("//div[@class = 'nav']/a[" + i + "]")).Text
                    });
                }
            }
        }

        public class BeInspired_Navigation
        {
            public string altText { get; set; }
        }
    }
}