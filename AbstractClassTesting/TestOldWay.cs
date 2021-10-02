using AbstractClassExample;
using AbstractClassExample.OldWay;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AbstractClassTesting
{
    [TestClass]
    public class TestOldWay
    {
        [TestMethod]
        public void TestAirCraft737FlightTimeGeneration()
        {

            DateTime TakeOffTime = new DateTime(2021,10,2,5,0,0);
            DateTime LandingTime = new DateTime(2021,10,2,8,0,0);
            Aircraft A = new Aircraft();
            TimeSpan T = A.CalculateFlightTime(TakeOffTime,LandingTime);
            Assert.AreEqual(3, T.TotalHours);

        }

        [TestMethod]
        public void TestFightRouteAircraftPass()
        {
            Route MyRoute = new Route();
            Aircraft A = new Aircraft();
            MyRoute.AddLeg(500);
            bool FuelCheckPass = MyRoute.CheckFuelAgainstRoute(A.FuelCapacity,A.GallonsPerMinuteInFlight);

            Assert.AreEqual(true, FuelCheckPass);
        }


        [TestMethod]
        public void TestFightRouteAircraftFail()
        {
            Route MyRoute = new Route();
            Aircraft A = new Aircraft();
            MyRoute.AddLeg(10000);
            bool FuelCheckPass = MyRoute.CheckFuelAgainstRoute(A.FuelCapacity, A.GallonsPerMinuteInFlight);

            Assert.AreEqual(false, FuelCheckPass);
        }

        [TestMethod]
        public void TestAirCraftFlightTimeGenerationWithWakeTurbulenceMedium()
        {

            DateTime TakeOffTime = new DateTime(2021, 10, 2, 5, 0, 0);
            DateTime LandingTime = new DateTime(2021, 10, 2, 7, 0, 0);
            Aircraft A = new Aircraft();
            TimeSpan T = A.CalculateFlightTimeWithIdle(TakeOffTime, LandingTime,General.WakeTurbulenceCategoryEnum.MEDIUM);
            Assert.AreEqual(123, T.TotalMinutes);

        }
    }
}
