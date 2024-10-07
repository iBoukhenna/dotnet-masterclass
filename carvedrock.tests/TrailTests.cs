using Microsoft.VisualStudio.TestTools.UnitTesting;
using carvedrock.bl.tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.tests
{
    [TestClass()]
    public class TrailTests
    {
        [TestMethod()]
        public void EstimateTime6Miles2000Elevation()
        {
            // 1. Arrange
            Trail trail = new() { DistanceInMiles = 6, ElevationInFeet = 2000 };
            double expected = 3.0;

            // 2. Act
            double actual = trail.EstimateTime();

            // 3. Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod()]
        public void EstimateTimeWithNegativeDistance()
        {
            // 1. Arrange
            Trail trail = new() { DistanceInMiles = -1, ElevationInFeet = 2000 };

            try
            {
                // 2. Act
                double _ = trail.EstimateTime();

                // 3. Assert
                Assert.Fail("Exception should be thrown");
            }
            catch 
            {
                Console.WriteLine("Exception thrown");
            }
        }

        [TestMethod()]
        public void EstimateTimeNegativeElevation()
        {
            // 1. Arrange
            Trail trail = new() { DistanceInMiles = 6, ElevationInFeet = -2000 };
            double notExpected = 1.0;

            // 2. Act
            double actual = trail.EstimateTime();

            // 3. Assert
            Assert.AreNotEqual(notExpected, actual);
        }
    }
}