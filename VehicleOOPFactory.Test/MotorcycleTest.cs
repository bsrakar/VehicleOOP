using NUnit.Framework;
using System;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    public class MotorcycleTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatingMotorcycleObject_DefaultBrand_Null()
        {
            Motorcycle motorcycle = new Motorcycle();

            Assert.IsNull(motorcycle.Brand);
        }
    }
}
