using System;
using System.Collections.Generic;
using System.Linq;
using Mendeova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MendeovaTests
{
    [TestClass]
    public class DiscountOnFixedPriceTests
    {
        private List<Item> myReceipt;
        private double myTotalPrice;
        private DiscountOnFixedPrice discount;

        [TestInitialize]
        public void Initialize()
        {
            myReceipt = new List<Item> {
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Jablka", 5.0),
                new Item("Jablka", 5.0),
                new Item("Jablka", 5.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Pomeranče", 6.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0),
                new Item("Banány", 10.0),
                new Item("Banány", 10.0),
                new Item("Pomeranče", 6.0)};

            myTotalPrice = myReceipt.Sum(item => item.Price);
            discount = new DiscountOnFixedPrice();
        }

        [TestMethod]
        public void ApplySpecialOfferTestAssert()
        {
            Assert.AreEqual(121.5, discount.ApplySpecialOffer(myReceipt, myTotalPrice));
            Assert.AreNotEqual(220, discount.ApplySpecialOffer(myReceipt, myTotalPrice));
        }
    }
}
