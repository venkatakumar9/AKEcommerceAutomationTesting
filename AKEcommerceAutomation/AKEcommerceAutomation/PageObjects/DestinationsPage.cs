using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using AKEcommerceAutomation.Framework;

namespace AKEcommerceAutomation.PageObjects
{
    public class DestinationsPage : BasePage

    {
        public DestinationsPage(IWebDriver driver) : base(driver)
        {
            
        }

<<<<<<< HEAD
=======
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
<<<<<<< HEAD

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
=======
>>>>>>> Vector map
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
<<<<<<< HEAD
=======
>>>>>>> 912cc867cadbf31346164713ad09be5e9424e333
>>>>>>> Vector map

    }
}
