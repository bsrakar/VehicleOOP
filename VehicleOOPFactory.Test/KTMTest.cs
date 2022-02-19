using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOPFactory.Test
{
    [TestFixture]
    class KTMTest
    {
      
        [Test]
        public void CreatingKtmObject_DefaultBrand_NotNull()
        {
            KTM ktm = new KTM();

            Assert.IsNotNull(ktm.Brand);
        }

        [Test]
        public void CreatingKtmObject_DefaultBrand_KTM()
        {
            KTM ktm = new KTM();

            Assert.AreEqual("KTM", ktm.Brand);
        }

        [Test]
        public void CreatingKtmObject_MoveMethod_Motorcycle()
        {
            Motorcycle ktm = new KTM();
            string expected = "You are driving a motorcycle from KTM";

            Assert.AreEqual(expected, ktm.Move());
        }
    }
}
