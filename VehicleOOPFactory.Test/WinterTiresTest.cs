using NUnit.Framework;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    class WinterTiresTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatingWinterTiresObject_PressureCheck_Equal()
        {
            WinterTires winterTires = new WinterTires(3, 4, 5);

            Assert.AreEqual(3, winterTires.GetPressure);
        }

        [Test]
        public void CreatingWinterTiresObject_MinTempCheck_Equal()
        {
            WinterTires winterTires = new WinterTires(3, 4, 5);

            Assert.AreEqual(4, winterTires.MinTemp);
        }

        [Test]
        public void CreatingWinterTiresObject_ThicknessCheck_Equal()
        {
            WinterTires winterTires = new WinterTires(3, 4, 5);

            Assert.AreEqual(5, winterTires.Thickness);
        }

        [Test]
        public void CreatingWinterTiresObject_InfoMethod_Equal()
        {
            WinterTires winterTires = new WinterTires(3, 4, 5);
            string expected = "Your winter tires consist of pressure 3, minimum temperature 4 and thickness 5";

            Assert.AreEqual(expected, winterTires.GetTiresInfo());
        }
    }
}
