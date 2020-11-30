using System;
using TechTalk.SpecFlow;

namespace lernen_bdd
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the first number is pi")]
        public void GivenTheFirstNumberIsPi()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the number is pi")]
        public void GivenTheNumberIsPi()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the sinus is selected")]
        public void WhenTheSinusIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the cosinus is selected")]
        public void WhenTheCosinusIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
