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
    public class IteratorSteps
    {
        private int _infoAddition = new Addition(0);
        private int _infoSubstraction = new Substraction(0);
        private int _infoMultiplication = new Multiplication(0);
        private ILog log;
        private IFileWriter _fileWriter;
        private ICreator _creator;
        
        [Given(@"the result of an addition is (.*)")]
        public void GivenTheResultOfAnAdditionIs(int p0)
        {
            _infoAddition(p0);
        }
        
        [Given(@"the result of a substraction is (.*)")]
        public void GivenTheResultOfASubstractionIs(int p1)
        {
            _infoSubstraction(p1);
        }
        
        [Given(@"the result of an multiplication is (.*)")]
        public void GivenTheResultOfAnMultiplicationIs(int p2)
        {
            _infoMultiplication(p2);
        }

        [Then(@"the results in the log screen should be '(.*)', '(.*)', '(.*)'")]
        public void ThenTheResultsInTheLogScreenShouldBe()
        {
            _creatorAdd = new AdditionCreator();
            _creatorSub = new SubstractionCreator();
            _creatorMult = new MultiplicationCreator();
            log = new Multiplication(new Substraction(new Addition(new BaseLog(), _infoAddition), _infoSubstraction), _infoMultiplication);
            List<string> resultList = log.GetLog();
            _fileWriter = new FileWriter();
            _fileWriter.WriteLog(resultList);

            Assert.AreEqual(p0, resultList.ElementAt(0));
            Assert.AreEqual(p1, resultList.ElementAt(1));
            Assert.AreEqual(p2, resultList.ElementAt(2));
        }
    }
}
