using System;
using System.Collections.Generic;
using System.Linq;
using Mendeova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MendeovaTests
{
    [TestClass]
    public class ApplyAllSpecialOffersTests
    {
        private List<Item> myReceipt;
        private double myTotalPrice;
        private ApplySpecialOffers applySpecialOffers;

        [TestInitialize]
        public void Initialize()
        { 
            myReceipt = new List<Item> {
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Jablka", 5.0),
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Jablka", 5.0),
                new Item("Jablka", 5.0),
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Pomeranče", 6.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0)};

            myTotalPrice = myReceipt.Sum(item => item.Price);
            applySpecialOffers = new ApplySpecialOffers(myReceipt, myTotalPrice);
        }

        [TestMethod]
        public void ApplyAllSpecialOffersAssert()
        {
            Assert.AreEqual(113.4, applySpecialOffers.TotalPrice);
            Assert.AreNotEqual(126, applySpecialOffers.TotalPrice);
        }
    }
}
