//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation.PageObjects
{
    using System;
    using System.Drawing.Imaging;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using Framework;
    using Object_Repository;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;

    public class BasePage : SeleniumTestBase
    {
        protected IWebDriver _driver;
        //private IBasePageStrategy _skin;
        private string topmenucontinetnames = null;

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
            mouse.ContextClick(loc.Coordinates);
        }

        public void Meganav()
        {
            foreach (IWebElement continent in driver.FindElements(HomePageElements.Meganavmenutop))
            {
                string continentname = continent.Text;
                continent.Click();
                string title = driver.Title;
                driver.Navigate().Back();
                mouseover(HomePageElements.Destinationlink);
            }

            foreach (IWebElement continent in driver.FindElements(HomePageElements.Meganavmenubottom))
            {
                string continentname = continent.Text;
                continent.Click();
                string title = driver.Title;
                driver.Navigate().Back();
                mouseover(HomePageElements.Destinationlink);
            }
        }

        //UN-Comment When JourneyPage is Written
        //public string GetJourneysPage()
        //{
        //    driver.FindElement(By.XPath("//*[@id='journeys']")).Click();
        //    driver.WaitForPageToLoad();
        //    return new JourneysPage(_driver);

        //}


        //private readonly string WebUrl;

        //public void Navigate()
        //{
        //    driver.Navigate().GoToUrl(WebUrl);
        //    driver.Manage().Window.Maximize();

        //}

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
    }
}