using System;
using AKEcommerceAutomation.Framework;
using OpenQA.Selenium;

//*** This Class Does Nothing- All the previous methods which are un-used saved here ***//
// *** ---- ***//

namespace AKEcommerceAutomation.PageObjects
{
    public class OptedoutMethods : SeleniumTestBase
    {
        protected IWebDriver _driver;
        //private IBasePageStrategy _skin;

        protected OptedoutMethods(IWebDriver driver)

        {
            _driver = driver;
        }

        public string[] GetFooterHigherValues()
        {
            var footerHighLevelValues = new string[GetFooterHighLevelCount()];
            for (int i = 0; i < 4; i++)
            {
                footerHighLevelValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='pre-footer']/div[" + (i + 1) + "]/h4")).Text;
            }
            return footerHighLevelValues;
        }

        public int GetFooterSecondLevelCount()
        {
            return _driver.FindElements(By.XPath("//*[@id='pre-footer']/div[1]/ul")).Count;
        }

        public int GetFooterHighLevelCount()
        {
            return _driver.FindElements(By.XPath("//*[@id='pre-footer']/div")).Count;
        }

        public int GetFooterThirdLevelCount()
        {
            return _driver.FindElements(By.XPath("//*[@id='pre-footer']/div[1]/ul/li/a")).Count;
        }

        public string[] GetFooterLowerValues()
        {
            var footerlowLevelValues = new String[GetFooterSecondLevelCount()];
            for (int i = 0; i < 3; i++)
            {
                footerlowLevelValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='pre-footer']/div[1]/ul[" + (i + 1) + "]/span")).Text;
            }
            return footerlowLevelValues;
        }

        public string[] GetFooterLinkValues()
        {
            var footerLinkValues = new string[GetFooterHighLevelCount()];

            for (int i = 0; i < GetFooterHighLevelCount(); i++)
            {
                footerLinkValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='pre-footer']/div[1]/ul[" + (i + 1) + "]/span")).GetAttribute(
                        "href");
            }

            return footerLinkValues;
        }
    }
}
