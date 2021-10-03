using AbstractClassExample;
using AbstractClassExample.OldWay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AbstractClassExample.AbstractWay;



namespace AbstractClassTesting
{
    [TestClass]
    public class TestNewWay
    {

        [TestMethod]
        public void Test737ETOPSRules()
        {
            Aircraft737 MyAircraft = new Aircraft737();
            Assert.AreEqual(180, MyAircraft.ETOPS);


        }

        [TestMethod]
        public void Test707MultipleInheratance()
        {
            Aircraft707 MyAirCraft = new Aircraft707();
            Assert.AreEqual(true, MyAirCraft.ManifestCheck());
        }

    }
}
