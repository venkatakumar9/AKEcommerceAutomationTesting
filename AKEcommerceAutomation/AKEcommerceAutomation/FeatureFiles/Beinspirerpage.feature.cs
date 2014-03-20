﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AKEcommerceAutomation.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Be-InspiredPage")]
    public partial class Be_InspiredPageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Beinspirerpage.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Be-InspiredPage", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verifying the navigation in Be-inspired page")]
        public virtual void VerifyingTheNavigationInBe_InspiredPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verifying the navigation in Be-inspired page", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("I am on the AK homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.When("I click on BeInspired tab on homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table1.AddRow(new string[] {
                        "PLACES TO VISIT"});
            table1.AddRow(new string[] {
                        "THINGS TO SEE & DO"});
            table1.AddRow(new string[] {
                        "WHERE TO STAY"});
            table1.AddRow(new string[] {
                        "MY PINBOARD"});
#line 13
testRunner.Then("Be-inspired Navigation Links displayed:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete the Inspirer Instructional text and cookies to re-enable the Inspirer Inst" +
            "ructional text")]
        public virtual void DeleteTheInspirerInstructionalTextAndCookiesToRe_EnableTheInspirerInstructionalText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete the Inspirer Instructional text and cookies to re-enable the Inspirer Inst" +
                    "ructional text", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
testRunner.Given("I am on beinspired page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
testRunner.When("I close the Inspirer Instructional text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.And("I delete all the cookies in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
testRunner.Then("Inspirer Instructional text re-appears.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Inspirer Categories in Be-inspired page")]
        public virtual void VerifyInspirerCategoriesInBe_InspiredPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Inspirer Categories in Be-inspired page", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
testRunner.When("I navigate to beinspired page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.Then("inspirer category images appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verifying inspirer images when clicked on PLACES TO VISIT category")]
        public virtual void VerifyingInspirerImagesWhenClickedOnPLACESTOVISITCategory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verifying inspirer images when clicked on PLACES TO VISIT category", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
testRunner.When("I click on Places to visit inspirer category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
testRunner.Then("Inspirer images should appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verifying inspirer images when clicked on THINGS TO SEE & DO category")]
        public virtual void VerifyingInspirerImagesWhenClickedOnTHINGSTOSEEDOCategory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verifying inspirer images when clicked on THINGS TO SEE & DO category", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
testRunner.When("I click on THINGS TO SEE AND DO inspirer category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("Inspirer images appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verifying inspirer images when clicked on WHERE TO STAY category")]
        public virtual void VerifyingInspirerImagesWhenClickedOnWHERETOSTAYCategory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verifying inspirer images when clicked on WHERE TO STAY category", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
testRunner.When("I click on where to stay inspirer category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
testRunner.Then("where to stay inspirer images displays", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verifying the pinboard count in Mypinboard and in Right Hand Side Bar when user a" +
            "dds any image to Pinboard.")]
        public virtual void VerifyingThePinboardCountInMypinboardAndInRightHandSideBarWhenUserAddsAnyImageToPinboard_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verifying the pinboard count in Mypinboard and in Right Hand Side Bar when user a" +
                    "dds any image to Pinboard.", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
testRunner.When("I add an image to my pinboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
testRunner.Then("Pinboard count appears on My Pinboard and on Right Hand Bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
