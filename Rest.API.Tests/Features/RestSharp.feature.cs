﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Rest.API.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RestSharp")]
    public partial class RestSharpFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RestSharp.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RestSharp", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("RestSharp Example")]
        [NUnit.Framework.CategoryAttribute("RestSharp")]
        public virtual void RestSharpExample()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("RestSharp Example", new string[] {
                        "RestSharp"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have an example endpoint http://www.thomas-bayer.com/sqlrest/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I search for all customers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the result contains customer Laura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("RestSharp Get Customer Record")]
        [NUnit.Framework.TestCaseAttribute("0", "Laura", "Steel", "429 Seventh Av.", "Dallas", new string[0])]
        public virtual void RestSharpGetCustomerRecord(string iD, string firstName, string lastName, string street, string city, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("RestSharp Get Customer Record", exampleTags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
  testRunner.Given("I have an example endpoint http://www.thomas-bayer.com/sqlrest/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
  testRunner.When("I search for customer record 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
  testRunner.Then(string.Format("the result contains customer {0}", iD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.Then(string.Format("the result contains customer {0}", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
  testRunner.Then(string.Format("the result contains customer {0}", lastName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
  testRunner.Then(string.Format("the result contains customer {0}", street), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
  testRunner.Then(string.Format("the result contains customer {0}", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Product Price")]
        public virtual void PostProductPrice()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Product Price", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
  testRunner.Given("I have an example endpoint http://www.thomas-bayer.com/sqlrest/", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
  testRunner.And("I update the price of Product 1 to 10.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.When("I search for Product 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
  testRunner.Then("the price is 10.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.And("I reset the price of product 1 to 24.8", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
