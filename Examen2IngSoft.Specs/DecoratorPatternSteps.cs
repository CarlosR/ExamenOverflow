using Examen2IngSoft.Specs.Implements;
using Examen2IngSoft.Specs.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;

namespace Examen2IngSoft.Specs
{
    [Binding]
    public class DecoratorPatternSteps
    {
        private int _additionResult = 0;
        private int _substractionResult = 0;
        private int _multiplicationResult = 0;
        private ILog log;
        private IFileWriter _fileWriter;

        private ICreator _creator;

        [Given(@"the result of an addition is (.*)")]
        public void GivenTheResultOfAnAdditionIs(int p0)
        {
            _additionResult = p0;
        }
        
        [Given(@"the result of a substraction is (.*)")]
        public void GivenTheResultOfASubstractionIs(int p1)
        {
            _substractionResult = p1;
        }
        
        [Given(@"the result of an multiplication is (.*)")]
        public void GivenTheResultOfAnMultiplicationIs(int p2)
        {
            _multiplicationResult = p2;
        }

        [Then(@"the log string should be '(.*)', '(.*)', '(.*)'")]
        public void ThenTheLogStringShouldBe(string p0, string p1, string p2)
        {
            _creator = new MultiplicationCreator();
            log = new Multiplication(new Substraction(new Addition(new BaseLog(),_additionResult), _substractionResult), _multiplicationResult);
            List<string> resultList = log.GetLog();
            _fileWriter = new FileWriter();
            _fileWriter.WriteLog(resultList);

            Assert.AreEqual(p0, resultList.ElementAt(0));
            Assert.AreEqual(p1, resultList.ElementAt(1));
            Assert.AreEqual(p2, resultList.ElementAt(2));
        }
    }
}
