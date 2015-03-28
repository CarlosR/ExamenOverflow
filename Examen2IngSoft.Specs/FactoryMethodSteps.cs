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

        private ICreator _creator;
       
        [Given(@"a text file")]
        public void GivenATextFile()
        {
            FileReader.OpenFile("TestData.txt");
        }

        [Given(@"two addition numbers")]
        public void GivenTwoAdditionNumbers()
        {
            var line = FileReader.SearchLine("Suma");
            FileReader.CloseFile();
            if (string.IsNullOrEmpty(line)) return;
            
            var wordArray = line.Split(' ');

            _num1 = Convert.ToInt32(wordArray[1]);
            _num2 = Convert.ToInt32(wordArray[2]);
        }

        [Given(@"two substraction numbers")]
        public void GivenTwoSubstractionNumbers()
        {
            var line = FileReader.SearchLine("Resta");
            FileReader.CloseFile();
            if (string.IsNullOrEmpty(line)) return;
            
            var wordArray = line.Split(' ');

            _num1 = Convert.ToInt32(wordArray[1]);
            _num2 = Convert.ToInt32(wordArray[2]);
        }

        [Given(@"two multiplication numbers")]
        public void GivenTwoMultiplicationNumbers()
        {
            var line = FileReader.SearchLine("Mult");
            FileReader.CloseFile();
            if (string.IsNullOrEmpty(line)) return;
            var wordArray = line.Split(' ');

            _num1 = Convert.ToInt32(wordArray[1]);
            _num2 = Convert.ToInt32(wordArray[2]);
        }

        [Then(@"the addition result should be (.*)")]
        public void ThenTheAdditionResultShouldBe(int p0)
        {
            _creator=new AdditionCreator();
            var operation=_creator.FactoryMethod(new BaseLog());
            var result=operation.Resolve(_num1, _num2);
            
            Assert.AreEqual(p0,result);
        }
        
        [Then(@"the substraction result should be (.*)")]
        public void ThenTheSubstractionResultShouldBe(int p0)
        {
            _creator = new SubstractionCreator();
            var operation = _creator.FactoryMethod(new BaseLog());
            var result = operation.Resolve(_num1, _num2);

            Assert.AreEqual(p0, result);
        }

        [Then(@"the multiplication result should be (.*)")]
        public void ThenTheMultiplicationResultShouldBe(int p0)
        {
            _creator = new MultiplicationCreator();
            var operation = _creator.FactoryMethod(new BaseLog());
            var result = operation.Resolve(_num1, _num2);

            FileReader.CloseFile();
            Assert.AreEqual(p0, result);


        }
    }
}
