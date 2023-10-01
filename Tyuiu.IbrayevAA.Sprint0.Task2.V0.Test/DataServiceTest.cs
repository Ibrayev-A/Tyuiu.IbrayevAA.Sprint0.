using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IbrayevAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Абай";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Абай", res);
        }
    }
}
