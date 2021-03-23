using System;
using Mendeova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MendeovaTests
{
    [TestClass]
    public class CheckoutTests
    {
        private Checkout checkout;

        [TestInitialize]
        public void Initialize()
        {
            checkout = new Checkout();
        }

        [TestMethod]
        public void ScanTestAssert()
        {
            checkout.Scan(new Item("Pomeranče", 6.0));

            Assert.AreEqual(1, checkout.Receipt.Count);
            Assert.AreNotEqual(3, checkout.Receipt.Count);
        }

        [TestMethod]
        public void TotalTestAssert1()
        {
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));

            Assert.AreEqual(20.0, checkout.Total());
            Assert.AreNotEqual(22.0, checkout.Total());
        }

        [TestMethod]
        public void TotalTestAssert2()
        {
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Banány", 10.0));
            checkout.Scan(new Item("Pomeranče", 6.0));
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Jablka", 5.0));
            checkout.Scan(new Item("Pomeranče", 6.0));
            checkout.Scan(new Item("Pomeranče", 6.0));
            checkout.Scan(new Item("Pomeranče", 6.0));
            checkout.Scan(new Item("Pomeranče", 6.0));
            checkout.Scan(new Item("Pomeranče", 6.0));
            checkout.Scan(new Item("Pomeranče", 6.0));

            Assert.AreEqual(116.1, checkout.Total());
            Assert.AreNotEqual(107.0, checkout.Total());
        }

    }
}

