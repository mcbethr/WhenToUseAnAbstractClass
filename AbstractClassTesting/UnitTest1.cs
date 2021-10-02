using AbstractClassExample;
using AbstractClassExample.OldWay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AbstractClassTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAirCraft737FlightTimeGeneration()
        {

            DateTime TakeOffTime = new DateTime(2021,10,2,5,0,0);
            DateTime LandingTime = new DateTime(2021,10,2,8,0,0);
            Aircraft737 A = new Aircraft737();
            TimeSpan T = A.CalculateFlightTime(TakeOffTime,LandingTime);
            Assert.AreEqual(3, T.TotalHours);

        }

        [TestMethod]
        public void TestFightRoute737Pass()
        {
            Route MyRoute = new Route();
            Aircraft737 A = new Aircraft737();
            MyRoute.AddLeg(500);
            bool FuelCheckPass = MyRoute.CheckFuelAgainstRoute(A.FuelCapacity,A.GallonsPerMinuteInFlight);

            Assert.AreEqual(true, FuelCheckPass);
        }

        [TestMethod]
        public void TestFightRoute737Fail()
        {
            Route MyRoute = new Route();
            Aircraft737 A = new Aircraft737();
            MyRoute.AddLeg(10000);
            bool FuelCheckPass = MyRoute.CheckFuelAgainstRoute(A.FuelCapacity, A.GallonsPerMinuteInFlight);

            Assert.AreEqual(false, FuelCheckPass);
        }
    }
}
