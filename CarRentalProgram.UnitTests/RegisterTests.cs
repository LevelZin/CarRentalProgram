using NUnit.Framework;

namespace CarRentalProgram.UnitTests
{
    [TestFixture]
    public class RegisterTests
    {
        [Test]
        public void GetCarMileage_ValidString_ReturnsInt()
        {
            var mileage = "3400";

            var result = Register.GetCarMileage(mileage);
            
            Assert.That(mileage == result.ToString());
        }
    }
}
