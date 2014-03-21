using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using OpenQA.Selenium;

namespace AKEcommerceAutomation.PageObjects
{
    public class ContinentPage : BasePage
    {
        public ContinentPage(IWebDriver driver) : base(driver)
        {
            
        }

        public string[] continentnavlinks()
        {
            var continetnav = new string[_driver.FindElements(ContinentPageElements.Navigation).Count];
            for (int i = 0; i < _driver.FindElements(ContinentPageElements.Navigation).Count; )
            {
                waitforelement(ContinentPageElements.Navigation, 10);
                foreach (IWebElement continentnav in driver.FindElements(ContinentPageElements.Navigation))
                {
                    continetnav[i] = continentnav.Text;
                    i++;
                }
            }
            return continetnav;
        }

        public string[] countries()
        {
            var countries = new string[_driver.FindElements(ContinentPageElements.countries).Count];
            for (int i = 0; i < _driver.FindElements(ContinentPageElements.countries).Count; )
            {
                waitforelement(ContinentPageElements.Navigation, 10);
                foreach (IWebElement country in driver.FindElements(ContinentPageElements.countries))
                {
                    countries[i] = country.Text;
                    i++;
                }
            }
            return countries;
        }
    }
}
