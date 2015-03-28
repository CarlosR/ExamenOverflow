using System;
using Examen2IngSoft.Specs.Implements;
using Examen2IngSoft.Specs.Interfaces;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Examen2IngSoft.Specs
{
    [Binding]
    public class FactoryMethodSteps
    {
        private int _num1 = 0;
        private int _num2 = 0;
        private ILog log = new BaseLog();

        private ICreator _creator;

        [Given(@"the first number (.*)")]
        public void GivenTheFirstNumber(int p0)
        {
            _num1 = p0;
        }

        [Given(@"the second number (.*)")]
        public void GivenTheSecondNumber(int p0)
        {
            _num2 = p0;
        }

        [Then(@"the addition result should be (.*)")]
        public void ThenTheAdditionResultShouldBe(int p0)
        {
            _creator=new AdditionCreator();
            var operation=_creator.FactoryMethod(log);
            var result=operation.Resolve(_num1, _num2);

            Assert.AreEqual(p0,result);
        }

        [Then(@"the substraction result should be (.*)")]
        public void ThenTheSubstractionResultShouldBe(int p0)
        {
            _creator = new SubstractionCreator();
            var operation = _creator.FactoryMethod(log);
            var result = operation.Resolve(_num1, _num2);

            Assert.AreEqual(p0, result);
        }

        [Then(@"the multiplication result should be (.*)")]
        public void ThenTheMultiplicationResultShouldBe(int p0)
        {
            _creator = new MultiplicationCreator();
            var operation = _creator.FactoryMethod(log);
            var result = operation.Resolve(_num1, _num2);

            Assert.AreEqual(p0, result);
        }
    }
}
