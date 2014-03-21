using System.Collections.Generic;
using System.Linq;
using AKEcommerceAutomation.PageObjects.Object_Repository;
using NUnit.Core;
using OpenQA.Selenium;
using System;

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
        public const string inspirerbackplacestovisit = "//div[@class = 'inspirer-back places-to-visit']/a/span";
        public const string inspirerbackthingstosee = "//div[@class = 'inspirer-back things-to-see']/a/span";
        public const string inspirerbackwheretostay = "//div[@class = 'inspirer-back where-to-stay']/a/span";


        public bool GetInspirerInstructionalText()
        {
            return _driver.FindElement(By.XPath("//*[@id='inspirerInstructionalText']/div/p")).Displayed;
            
        }

       public int GetBeinspiredNavigationCount()
        {
          
           return _driver.FindElements(By.XPath("//div[@class = 'nav']/a")).Count;
        }
        public string[] GetBeinspiredNavigationValues()
        {
            var beinspirednavigationValues = new string[GetBeinspiredNavigationCount()];
            for (int i = 0; i < GetBeinspiredNavigationCount(); i++)
            {
               beinspirednavigationValues[i] =
                        _driver.FindElement(By.XPath("//div[@class = 'nav']/a[" + (i + 1) + "]")).Text;
                if (i == 3)
                {
                   string[] split = beinspirednavigationValues[3].Split('\n');
                    beinspirednavigationValues[3] = split[1];
                }
            }
            return beinspirednavigationValues;
        }

        public BeInspiredPage Closeinspirertext()
        {
            _driver.FindElement(By.CssSelector(".closeInspirerInstructionalText.close")).Click();
            return new BeInspiredPage(_driver);
        }

       public void GetInspirerCategoryimagesSection()
        {
            int inspirerCategoryimages =
                _driver.FindElements(By.XPath("//*[@id='infiniteScrollItem']/div/div/div/section/article/a/span[2]/span"))
                    .Count;
            for (int i = 1; i <= inspirerCategoryimages; i++)
            {
                Console.WriteLine(driver.FindElement(By.XPath("//*[@id='infiniteScrollItem']/div/div["+i+"]/div/section/article/a/span[2]/span")).Text);
            }
        }

        public string InspirerCategory()
        {
           return _driver.FindElement(By.XPath("//div[@class = 'inspirer-back places-to-visit']/a/span")).Text;
        }

        public int GetInspirerImages_Category()
        {
            int inspirerimages = _driver.FindElements(By.XPath("//div[@class='pin-container']")).Count;

            Console.WriteLine(inspirerimages);

           return inspirerimages;
        }

        
    }
}