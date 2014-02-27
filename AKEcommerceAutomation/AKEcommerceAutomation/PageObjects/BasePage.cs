using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text;
using AKEcommerceAutomation.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

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


        public void GetPreFooter_QuickLinks()
        {
            int QuickLinks = _driver.FindElements(By.XPath("//div[@class = 'qick-links']/ul")).Count;
            for (int i = 1; i <= QuickLinks; i++)
            {
                Console.WriteLine(driver.FindElement(By.XPath("//div[@class = 'qick-links']/ul[" + i + "]")).Text);
            }
        }

        public void GetPreFooter_CountryLinks()
        {
            int Footerlinks_country = _driver.FindElements(By.XPath("//div[@class = 'country']/ul/li")).Count;
            for (int i = 1; i <= Footerlinks_country; i++)
            {
                Console.WriteLine(driver.FindElement(By.XPath("//div[@class = 'country']/ul/li[" + i + "]")).Text);
            }
        }

        public void GetPreFooter_Sociallinks()
        {
            int Sociallinks_footer = _driver.FindElements(By.XPath("//div[@class = 'follow']/ul[1]/li/a/img")).Count;
            int SocialLinks2_footer = _driver.FindElements(By.XPath("//div[@class = 'follow']/ul[2]/li/a/img")).Count;
            for (int i = 1; i <= Sociallinks_footer; i++)

            {
                Console.WriteLine(driver.FindElement(By.XPath("//div[@class = 'follow']/ul[1]/li[" + i + "]/a/img")).GetAttribute("title").ToString());
            }
            for (int j = 1; j <= SocialLinks2_footer; j++)
            {
                Console.WriteLine(driver.FindElement(By.XPath("//div[@class = 'follow']/ul[2]/li[" + j + "]/a/img")).GetAttribute("title").ToString());
            }
        }

        public bool GetPreFooter_SignUpforenews()
        {
            return _driver.FindElement(By.XPath("//*[@id='eNews']")).Displayed;
        }

        public void FooterLinks()
        {
            int footerlinks = _driver.FindElements(By.XPath("//*[@id='footer']/div[8]/div/div/footer/ul/li/a")).Count;
            for (int i = 1; i <= footerlinks; i++)
            {
                Console.WriteLine(driver.FindElement(By.XPath("//*[@id='footer']/div[8]/div/div/footer/ul/li["+i+"]/a")).Text);
            }
        }
      
        public const string CopyRightText = "All rights reserved. Copyright Abercombie & Kent 2013";

        public string GetCopyRightText()
        {
            return _driver.FindElement(By.XPath("//*[@id='footer']/div[8]/div/div/footer/p")).Text;
        }
       

        //JourneyPage 
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
            return _driver.FindElement(By.ClassName("side-bar")).Displayed;
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