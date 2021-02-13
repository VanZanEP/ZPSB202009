using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I enter onet\.pl")]
        public void GivenIEnterOnet_Pl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on (.*)")]
        public void GivenIClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill wrong email login")]
        public void WhenIFillWrongEmailLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill wrong password")]
        public void WhenIFillWrongPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I expect to see message as „Niestety podany login lub hasło")]
        public void ThenIExpectToSeeMessageAsNiestetyPodanyLoginLubHaslo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
