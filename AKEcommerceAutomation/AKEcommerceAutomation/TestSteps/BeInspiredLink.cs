//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AKEcommerceAutomation.TestSteps
{
    using Framework;
    using PageObjects;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    internal class BeInspiredLink
    {
        [Binding]
        public class Beisnpiredlink : SeleniumTestBase
        {
            #region BeInspired Link Navigation

            private readonly HomePage homepage = new HomePage(driver);

            [When(@"I click on BeInspired link")]
            public void WhenIClickOnBeInspiredLink()
            {
                homepage.GetBeInspiredPage();
            }

            [Then(@"I Navigate to BeInspired Page")]
            public void ThenINavigateToBeInspiredPage()
            {
               Assert.AreEqual("BeInspired",driver.Title);
            }

            #endregion
        }
    }
}