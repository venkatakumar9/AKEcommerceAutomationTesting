using AKEcommerceAutomation.PageObjects.Object_Repository;
using com.sun.org.apache.xml.@internal.resolver.helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AKEcommerceAutomation.PageObjects
{
    public class DestinationsPage : BasePage
    {
        public DestinationsPage(IWebDriver driver) : base(driver)
        {
           
        }
        public string title()
        {
            return driver.Title;
        }

        public string vectormapclick_Americas()
        {
            driver.FindElement(DestinationsPageElements.TheAmericas).Click();
            return driver.Title;
        }
        public string vectormapclick_Africa()
        {
            driver.FindElement(DestinationsPageElements.Africa).Click();
            return driver.Title;
        }
        public string vectormapclick_Asia()
        {
            driver.FindElement(DestinationsPageElements.Asia).Click();
            return driver.Title;
        }
        public string vectormapclick_Carribean()
        {
            driver.FindElement(DestinationsPageElements.Carribean).Click();
            return driver.Title;
        }
        public string vectormapclick_AutraliaAndNewzealand()
        {
            driver.FindElement(DestinationsPageElements.AustraliaAndNewzealand).Click();
            return driver.Title;
        }
        public string vectormapclick_IndianOcean()
        {
            driver.FindElement(DestinationsPageElements.IndianOcean).Click();
            return driver.Title;
        }
        public string vectormapclick_Arctic()
        {
            driver.FindElement(DestinationsPageElements.Arctic).Click();
            return driver.Title;
        }
        public string vectormapclick_Europe()
        {
            driver.FindElement(DestinationsPageElements.Europe).Click();
            return driver.Title;
        }
        public string vectormapclick_Antarctica()
        {
            driver.FindElement(DestinationsPageElements.Antarctica).Click();
            return driver.Title;
        }
        public string vectormapclick_Middleeast()
        {
            driver.FindElement(DestinationsPageElements.MiddleEast).Click();
            return driver.Title;
        }

        public string vectormapclick_IndiaAndHimalayas()
        {
            driver.FindElement(DestinationsPageElements.IndiaandHimalayas).Click();
            return driver.Title;
        }

    }
}