using System;
using Examen2IngSoft.Specs.Interfaces;
using TechTalk.SpecFlow;

namespace Examen2IngSoft.Specs
{
    [Binding]
    public class ObserverPatternSteps
    {
        private int _num1 = 0;
        private int _num2 = 0;
        private int average = 0;
        private ICreator _creator;


        [Given(@"I the sum change (.*) value (.*)")]
        public void GivenITheSumChangeValue(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"resul the sum is , now would be (.*)=(.*)")]
        public void GivenResulTheSumIsNowWouldBe(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"is calculate")]
        public void WhenIsCalculate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"average value us updated automatically")]
        public void ThenAverageValueUsUpdatedAutomatically()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
