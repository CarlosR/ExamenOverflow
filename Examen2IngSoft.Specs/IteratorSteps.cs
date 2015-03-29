using System;
using System.Collections.Generic;
using System.Linq;
using Examen2IngSoft.Specs.Implements;
using Examen2IngSoft.Specs.Interfaces;
using NUnit.Core;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Examen2IngSoft.Specs
{
    [Binding]
    public class IteratorSteps
    {

        private int _infoAddition;
        private int _infoSubstraction;
        private int _infoMultiplication;
        private ILog log;

        [Given(@"the result for HappyPath of an addition is (.*)")]
        public void GivenTheResultForHappyPathOfAnAdditionIs(int p0)
        {
            _infoAddition = p0;
        }

        [Given(@"the result for HappyPath of a substraction is (.*)")]
        public void GivenTheResultForHappyPathOfASubstractionIs(int p0)
        {
            _infoSubstraction = p0;
        }

        [Given(@"the result for HappyPath of an multiplication is (.*)")]
        public void GivenTheResultForHappyPathOfAnMultiplicationIs(int p0)
        {
            _infoMultiplication = p0;
        }


        [Then(@"the results in the log screen should be ""(.*)"", ""(.*)"", ""(.*)""")]
        public void ThenTheResultsInTheLogScreenShouldBe(string p0, string p1, string p2)
        {
            log = new Multiplication(new Substraction(new Addition(new BaseLog(), _infoAddition), _infoSubstraction), _infoMultiplication);
            List<string> resultList = log.GetLog();

            Assert.AreEqual(p0, resultList.ElementAt(0));
            Assert.AreEqual(p1, resultList.ElementAt(1));
            Assert.AreEqual(p2, resultList.ElementAt(2));
        }
    }
}
