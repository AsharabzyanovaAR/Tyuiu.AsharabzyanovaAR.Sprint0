using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AsharabzyanovaAR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AsharabzyanovaAR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DateServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алина";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет... Алина", res);
        }
    }
}
