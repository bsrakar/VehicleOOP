using NUnit.Framework;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    class ToyotaTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatingToyotaObject_DefaultBrand_NotNull()
        {
            Toyota toyota = new Toyota();

            Assert.IsNotNull(toyota.Brand);
        }

        [Test]
        public void CreatingToyotaObject_DefaultBrand_Toyota()
        {
            Toyota toyota = new Toyota();

            Assert.AreEqual("Toyota", toyota.Brand);
        }

        [Test]
        public void CreatingToyotaObject_DefaultCarTires_SummerTires()
        {
            Toyota toyota = new Toyota();
            SummerTires summerTires = new SummerTires(10, 10);

            Assert.AreEqual(toyota.CarTires.GetType().Name, summerTires.GetType().Name);
        }

        [Test]
        public void CreatingToyotaObject_ChangeCarTires_WinterTires()
        {
            Toyota toyota = new Toyota();
            WinterTires winterTires = new WinterTires(5, 10, 10);
            toyota.CarTires = winterTires;

            Assert.AreEqual(toyota.CarTires, winterTires);
        }

        [Test]
        public void CreatingToyotaObject_MoveMethod_Car()
        {
            Car toyota = new Toyota();
            string expected = "You are driving a car from Toyota";

            Assert.AreEqual(expected, toyota.Move());
        }

    }
}
