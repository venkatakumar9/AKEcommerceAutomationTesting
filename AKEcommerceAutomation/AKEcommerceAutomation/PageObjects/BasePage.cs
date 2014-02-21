//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AKEcommerceAutomation.PageObjects
{
    public class BasePage : SeleniumTestBase
    {
        protected IWebDriver _driver;
        //private IBasePageStrategy _skin;
        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public int RandomNumber()
        {
            var random = new Random();
            return random.Next(10000, 10000000);
        }

        public string GetUsernameFromConfig()
        {
            return EnvironmentConfiguration.Instance.GetEnvironmentVariable("L0GIN_USERNAME");
        }

        public string GetPasswordFromConfig()
        {
            return EnvironmentConfiguration.Instance.GetEnvironmentVariable("LOGIN_PASSWORD");
        }

        //***Commenting it untill login functionality is delivered. 
        //public static bool IsUserLoggedIn()
        //{
        //    if (driver.FindElement(By.Id("")).GetAttribute("class").Contains("loggedout"))
        //        return false;
        //    return true;
        //}
        public string GetHtmlTitle()
        {
            return _driver.Title;
        }

        public string GetUniqueValidUsername()
        {
            return RandomNumber().ToString(CultureInfo.InvariantCulture);
        }

        //***Get the valid Email: Un-comment when this functionality delivers
        //public string GetUniqueValidEmail()
        //{
        //    return RandomNumber().ToString(CultureInfo.InvariantCulture) + "@ak.com";
        //}

        //***Logo is not clickable: Make it available once it was delivered
        //public AKHomePage ClickTHELogo()
        //{
        //    _driver.FindElement(By.XPath("")).Click();
        //    _driver.WaitForPageToLoad();
        //    return new AKHomePage();
        //}
        public int GetHeaderNavigationCount()
        {
            return _driver.FindElements(By.XPath("//*[@id='page-wrapper']/div[2]/section/nav/a")).Count;
        }

        public int GetFooterCount()
        {
            return _driver.FindElements(By.XPath("//*[@id='footer']/div[2]/div")).Count;
        }

        public int GetHeaderLinks()
        {
            return _driver.FindElements(By.XPath("//*[@id='Header_TD96F3DA9018_Col01']/ul/li")).Count;
        }

        public string[] GetHeaderLinksValues()
        {
            var headerlinksValues = new string[GetHeaderLinks()];
            for (int i = 0; i < GetHeaderLinks(); i++)
            {
                headerlinksValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='Header_TD96F3DA9018_Col01']/ul/li[" + (i + 1) + "]")).Text;
            }
            return headerlinksValues;
        }

        public string[] GetHeaderValues()
        {
            var headerValues = new string[GetHeaderNavigationCount()];
            for (int i = 0; i < GetHeaderNavigationCount(); i++)
            {
                headerValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='page-wrapper']/div[2]/section/nav/a[" + (i + 1) + "]"))
                        .Text;
            }
            return headerValues;
        }

        public string[] GetFooterValues()
        {
            var footerValues = new string[GetFooterCount()];
            for (int i = 0; i < GetFooterCount(); i++)
            {
                footerValues[i] = _driver.FindElement(By.XPath("//*[@id='footer']/div[2]/div[" + (i + 1) + "]/a")).Text;
            }
            return footerValues;
        }

        public string[] GetFooterLinkValues()
        {
            var footerLinkValues = new string[GetFooterCount()];
            for (int i = 0; i < GetFooterCount(); i++)
            {
                footerLinkValues[i] =
                    _driver.FindElement(By.XPath("//*[@id='footer']/div[2]/div[" + (i + 1) + "]/a")).GetAttribute(
                        "href");
            }
            return footerLinkValues;
        }

        public string GetCopyRightText()
        {
            return _driver.FindElement(By.XPath("//*[@id='footer']/div[2]/div/div/footer/p")).Text;
        }

        public void mouseover(By Elemnent)
        {
            var loc = (ILocatable) driver.FindElement(Elemnent);
            IMouse mouse = ((IHasInputDevices) driver).Mouse;
            mouse.MouseMove(loc.Coordinates);
            mouse.MouseMove(loc.Coordinates);
        }

        public string[] Meganav_topcontinetnames()
        {
            var continetnamestop = new string[_driver.FindElements(HomePageElements.Meganavmenutop).Count];
            for (int i = 0; i < _driver.FindElements(HomePageElements.Meganavmenutop).Count;)
            {
                waitforelement(HomePageElements.Meganavmenutop, 10);
                Thread.Sleep(3000);
                foreach (IWebElement continent in  driver.FindElements(HomePageElements.Meganavmenutop))
                {
                    continetnamestop[i] = continent.Text;
                    i++;
                }
            }
            return continetnamestop;
        }

        public string[] Meganav_bottomcontinentnames()
        {
            var continetnamesbottom = new string[_driver.FindElements(HomePageElements.Meganavmenubottom).Count];
            for (int i = 0; i < _driver.FindElements(HomePageElements.Meganavmenubottom).Count;)
            {
                waitforelement(HomePageElements.Meganavmenubottom, 10);
                foreach (IWebElement continent in driver.FindElements(HomePageElements.Meganavmenubottom))
                {
                    continetnamesbottom[i] = continent.Text;
                    i++;
                }
            }
            return continetnamesbottom;
        }

        public string[] Megamenu_topcounterynames()
        {
            var countrytop = new string[_driver.FindElements(HomePageElements.Meganavmenutopcountries).Count];
            for (int i = 0; i < _driver.FindElements(HomePageElements.Meganavmenutopcountries).Count; )
            {
                waitforelement(HomePageElements.Meganavmenutopcountries, 10);
                foreach (IWebElement country in driver.FindElements(HomePageElements.Meganavmenutopcountries))
                {
                    countrytop[i] = country.Text;
                    i++;
                }
            }
            return countrytop;
        }

        public string[] Megamenu_bottomcountrynames()
        {
            var countrybottom = new string[_driver.FindElements(HomePageElements.Meganavmenubottomcountries).Count];
            for (int i = 0; i < _driver.FindElements(HomePageElements.Meganavmenubottomcountries).Count; )
            {
                waitforelement(HomePageElements.Meganavmenubottomcountries, 10);
                foreach (IWebElement country in driver.FindElements(HomePageElements.Meganavmenubottomcountries))
                {
                    countrybottom[i] = country.Text;
                    i++;
                }
            }
            return countrybottom;
        }

        public void GoBack()
        {
            _driver.Navigate().Back();
        }

        public bool GetRightHandSideBar()
        {
            return _driver.FindElement(By.XPath(".//*[@id='page-wrapper']/div[1]/ul")).Displayed;
        }

        //Broken Images
        public void BrokenImages(IWebElement ele)
        {
            string str = ele.GetAttribute("src");
            if (str.EndsWith(".jpg"))
                Console.WriteLine("Pass");
            else
                Assert.Fail();
        }

        /* This is generic function used for capturing screenshot*/

        public void SaveScreenShot(string screenshotFirstName)
        {
            string folderLocation = "C:\\Projects\\ScreenShot";
            if (!Directory.Exists(folderLocation))
            {
                Directory.CreateDirectory(folderLocation);
            }
            Screenshot screenshot = ((ITakesScreenshot) driver).GetScreenshot();
            var filename = new StringBuilder(folderLocation);
            filename.Append(screenshotFirstName);
            filename.Append(DateTime.Now.ToString("ddMMyyyy"));
            filename.Append(".Jpeg");
            screenshot.SaveAsFile(filename.ToString(), ImageFormat.Jpeg);
        }

        public string GetElementText(By by)
        {
            return _driver.FindElement(by).Text;
        }

        public bool HasElement(By by)
        {
            switch (_driver.FindElements(@by).Count)
            {
                case 0:
                    return false;
                default:
                    return true;
            }
        }

        //Explicit wait
        public IWebElement waitforelement(By by, int timeinseconds)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeinseconds));
            IWebElement myDynamicElement = wait.Until(d =>
            {
                try
                {
                    return d.FindElement(by);
                }
                catch
                {
                    return null;
                }
            });
            return myDynamicElement;
        }
    }
}