using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mendeova;
using System.Collections.Generic;
using System.Linq;

namespace MendeovaTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetItemByNameTestAssert()
        {
            Assert.AreEqual(new Item("Pomeranče", 6.0).Price, Mendeova.Program.GetItemByName("Pomeranče").Price);
            Assert.AreNotEqual(new Item("Pomeranče", 6.0).Price, Mendeova.Program.GetItemByName("Jablka").Price);

            Assert.AreEqual(new Item("Pomeranče", 6.0).Name, Mendeova.Program.GetItemByName("Pomeranče").Name);
            Assert.AreNotEqual(new Item("Pomeranče", 6.0).Name, Mendeova.Program.GetItemByName("Hrušky").Name);
        }
    
    }
}
