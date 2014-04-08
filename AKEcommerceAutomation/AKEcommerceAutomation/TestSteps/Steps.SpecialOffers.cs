using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AKEcommerceAutomation.Framework;
using AKEcommerceAutomation.PageObjects;
using TechTalk.SpecFlow;

namespace AKEcommerceAutomation.TestSteps
{
    [Binding]
    public class SpecialfferSteps : SeleniumTestBase
    {
        private readonly HomePage homePage = new HomePage(driver);
        private readonly SpecialoffersPage specialofferpage = new SpecialoffersPage(driver);

        [When(@"I click on Special offers link in header")]
        public void WhenIClickOnSpecialOffersLinkInHeader()
        {
            homePage.GetSpecialoffersPage();
        }

        [Then(@"Special offers page appear")]
        public void ThenSpecialOffersPageAppear()
        {
            var title = driver.Title;
            Console.WriteLine(title);
        }

        [Then(@"special offers navigation exists")]
        public void ThenSpecialOffersNavigationExists()
        {
            specialofferpage.GetSpecialoffersnavigationValues();
            
        }

    }
}
