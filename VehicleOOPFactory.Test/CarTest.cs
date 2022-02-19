using NUnit.Framework;

using System;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    public class CarTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatingCarObject_DefaultBrand_Null()
        {
            Car car = new Car();

            Assert.IsNull(car.Brand);
        }

        [Test]
        public void CreatingCarObject_DefaultCarTires_NotNull()
        {
            Car car = new Car();

            Assert.IsNotNull(car.CarTires);
        }

        [Test]
        public void CreatingCarObject_DefaultCarTires_SummerTires()
        {
            Car car = new Car();
            SummerTires summerTires = new SummerTires(14,18);

            Assert.AreEqual(car.CarTires.GetType().Name,summerTires.GetType().Name);
        }
    }
}
