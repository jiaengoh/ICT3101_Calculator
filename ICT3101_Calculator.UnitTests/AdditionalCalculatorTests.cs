﻿using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using NUnit.Framework;
namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;

        private Mock<IFileReader> _mockFileReader;


        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("C:\\Users\\jiaen\\Desktop\\ICT3101_Calculator\\ICT3101_Calculator\\MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(0)]
        public void GetMagicNumber_WhenInputNumber1_ReturnNumberInFile(int p0)
        {
            //IFileReader fileReader = new FileReader();
            IFileReader fileReader = _mockFileReader.Object;
            Assert.That(_calculator.GenMagicNum(p0, fileReader), Is.EqualTo(0));
        }

    }
}
