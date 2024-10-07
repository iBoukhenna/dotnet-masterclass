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
    public class UnitConverterTests
    {
        [TestMethod()]
        public void Convert50KilometresToMiles()
        {
            // 1. Arrange
            decimal kilometres = 50.0M;
            decimal expected = 31.0686M;

            // 2. Act
            decimal actual = UnitConverter.KilometersToMiles(kilometres);
             
            // 3. Assert
            Assert.AreEqual(expected, actual);
        }
    }
}