using System;
using System.Collections.Generic;
using System.Linq;
using Mendeova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MendeovaTests
{
    [TestClass]
    public class DiscountOnPurchaseTests
    {
        private List<Item> myReceipt;
        private double myTotalPrice;
        private DiscountOnPurchase discount;

        [TestInitialize]
        public void Initialize()
        {
            myReceipt = new List<Item> {
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Pomeranče", 6.0),
                new Item("Pomeranče", 6.0),
                new Item("Pomeranče", 6.0)};

            myTotalPrice = myReceipt.Sum(item => item.Price);
            discount = new DiscountOnPurchase();
        }

        [TestMethod]
        public void ApplySpecialOfferTestAssert()
        {
            Assert.AreEqual(84, discount.ApplySpecialOffer(myReceipt, myTotalPrice));
            Assert.AreNotEqual(120, discount.ApplySpecialOffer(myReceipt, myTotalPrice));
        }

    }
}
