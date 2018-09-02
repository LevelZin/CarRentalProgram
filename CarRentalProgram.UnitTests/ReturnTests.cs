using System;
using NUnit.Framework;

namespace CarRentalProgram.UnitTests
{
    [TestFixture]
    class ReturnTests
    {
        [Test]
        public void NumberOfDaysRented_ValidDateTime_ReturnsDays()
        {
            DateTime rentAt = DateTime.UtcNow;
            DateTime returnAt = DateTime.UtcNow;

            var result = Return.NumberOfDaysRented(rentAt, returnAt);

            Assert.That(0 == result);
        }

        [Test]
        public void NumberOfKm_ValidInt_ReturnsNumberOfKm()
        {
            int oldMileage = 3000;
            int newMileage = 4000;
            int expectedResult = newMileage - oldMileage;

            var result = Return.NumberOfKm(oldMileage, newMileage);

            Assert.That(expectedResult == result);
        }
    }
}
