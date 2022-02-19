using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    class SummerTiresTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatingSummerTiresObject_MaxTempCheck_Equal()
        {
            SummerTires summerTires = new SummerTires(12,23);

            Assert.AreEqual(23, summerTires.MaxTemp);
        }

        [Test]
        public void CreatingSummerTiresObject_PressureCheck_Equal()
        {
            SummerTires summerTires = new SummerTires(12, 23);

            Assert.AreEqual(12, summerTires.GetPressure);
        }

        [Test]
        public void CreatingSummerTiresObject_InfoMethod_Equal()
        {
            SummerTires summerTires = new SummerTires(12, 23);
            string expected = "Your summer tires consist of pressure 12, maximum temperature 23";

            Assert.AreEqual(expected, summerTires.GetTiresInfo());
        }

    }
}
