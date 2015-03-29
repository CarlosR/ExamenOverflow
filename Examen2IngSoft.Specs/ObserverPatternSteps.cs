using System;
using System.Collections.Generic;
using System.Linq;
using Examen2IngSoft.Specs.Implements;
using Examen2IngSoft.Specs.Interfaces;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TechTalk.SpecFlow;

namespace Examen2IngSoft.Specs
{
    [Binding]
    public class ObserverPatternSteps
    {
        private int _resulSum=0;
        private int _resulRest = 0;
        private int _resulmult = 0;
        private double _average=0;
        private int _num1 = 0;
        private int _num2 = 0;
        readonly System.Collections.Generic.List<string> _resultList = new List<string>();

        [Given(@"I the sum change value (.*) to (.*)")]
        public void GivenITheSumChangeValueTo(int p0, int p1)
       {
            FileReader.OpenFile("TestData.txt");

            var line = FileReader.SearchLine("Suma");
            if (string.IsNullOrEmpty(line)) return;
            var wordArray = line.Split(' ');
            _num1 = p1;
            _num2 = Convert.ToInt32(wordArray[2]);;
            FileReader.CloseFile();

            Assert.AreEqual(p0, Convert.ToInt32(wordArray[1]));


        }

        [Given(@"resul the sum is (.*)")]
        public void GivenResulTheSumIs(int p0)
        {
            FileReader.OpenFile("Log.txt");
            
            _resultList.Add("Suma " + (_num1 + _num2));

            var line = FileReader.SearchLine("Resta");
            _resultList.Add(line);
            
            line = FileReader.SearchLine("Multiplicacion");
            _resultList.Add(line);

            FileReader.CloseFile();

            IFileWriter fileWriter = new FileWriter();
            fileWriter.WriteLog(_resultList);

            _resultList.Clear();
            

            Assert.AreEqual(p0, _num1+_num2);
        }

        [Given(@"a read text file")]
        public void GivenAReadTextFile()
        {
            FileReader.OpenFile("Log.txt");

            var line = FileReader.SearchLine("Suma");
            _resultList.Add(line);
            if (string.IsNullOrEmpty(line)) return;
            var wordArray = line.Split(' ');
            _resulSum = Convert.ToInt32(wordArray[1]);


            line = FileReader.SearchLine("Resta");
            _resultList.Add(line);
            if (string.IsNullOrEmpty(line)) return;
            wordArray = line.Split(' ');
            _resulRest = Convert.ToInt32(wordArray[1]);


            line = FileReader.SearchLine("Multiplicacion");
            _resultList.Add(line);
            if (string.IsNullOrEmpty(line)) return;
            wordArray = line.Split(' ');
            _resulmult = Convert.ToInt32(wordArray[1]);

            _average =Math.Round(Convert.ToDouble((_resulRest + _resulSum + _resulmult) / 3),2);
            _resultList.Add("Promedio " + _average);

            FileReader.CloseFile();
        }

        [Then(@"average value is updated automatically is (.*)")]
        public void ThenAverageValueUsUpdatedAutomaticallyIs(double p0)
        {
            IFileWriter fileWriter = new FileWriter();
            fileWriter.WriteLog(_resultList);

            Assert.AreEqual(p0, _average);
        }

    }
}
