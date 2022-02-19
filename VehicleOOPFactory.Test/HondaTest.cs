using NUnit.Framework;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    class HondaTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatingHondaObject_DefaultBrand_NotNull()
        {
            Car honda = new Honda();

            Assert.IsNotNull(honda.Brand);
        }

        [Test]
        public void CreatingHondaObject_DefaultBrand_Honda()
        {
            Car honda = new Honda();

            Assert.AreEqual("Honda", honda.Brand);
        }

        [Test]
        public void CreatingHondaObject_DefaultCarTires_SummerTires()
        {
            Car honda = new Honda();
            SummerTires summerTires = new SummerTires(10, 10);

            Assert.AreEqual(honda.CarTires.GetType().Name, summerTires.GetType().Name);
        }

        [Test]
        public void CreatingHondaObject_ChangeCarTires_WinterTires()
        {
            Car honda = new Honda();
            WinterTires winterTires = new WinterTires(1, (float)2.1, (float)10.68);
            honda.CarTires = winterTires;

            Assert.AreEqual(honda.CarTires, winterTires);
        }

        [Test]
        public void CreatingHondaObject_DefaultBrand_Null()
        {
            IMotorcycle honda = new Honda();

            Assert.IsNotNull(honda.Brand);
        }

        [Test]
        public void CreatingHondaObject_AssignBrand_Honda()
        {
            IMotorcycle honda = new Honda();
            honda.Brand = "Honda";

            Assert.AreEqual("Honda", honda.Brand);
        }

        [Test]
        public void CreatingHondaObject_MoveMethod_Car()
        {
            Car honda = new Honda();
            string expected = "You are driving a car from Honda";

            Assert.AreEqual(expected, honda.Move());
        }

        [Test]
        public void CreatingHondaObject_MoveMethod_Motorcycle()
        {
            IMotorcycle hondaMoto = new Honda();
            hondaMoto.Brand = "Honda";
            string expected = "You are driving a motorcycle from Honda";

            Assert.AreEqual(expected, hondaMoto.Move());
        }
    }
}
