using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.NovikovAA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void CheckSubtractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(15, 5));
        }

        [TestMethod]

        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }

        [TestMethod]
        public void CheckDivisionValid() 
        {
            Assert.AreEqual(5, DataService.Division(25, 5));
        }
    }
}
