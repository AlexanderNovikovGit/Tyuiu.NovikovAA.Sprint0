﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovikovAA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.NovikovAA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
