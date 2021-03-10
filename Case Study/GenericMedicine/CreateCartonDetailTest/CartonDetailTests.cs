using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCartonDetailTest
{
    [TestFixture]
    public class CartonDetailTests
    {
        private static Medicine GetMedicineObject(string s)
        {
            if(s.Equals("Medicine"))
            {
                return new Medicine()
                {
                    Name = "Name1",
                    GenericMedicineName = "Gen_Med_Name",
                    Composition = "Comp1",
                    ExpiryDate = new DateTime(2022, 12, 1),
                    PricePerStrip=30
                };
            }
            else
            {
                return null;
            }
            
        }
        [Test]
        [TestCase(5,"2022/11/6", "Address1","Medicine")]
        [TestCase(5, "2022/6/7", "Address1", "Medicine")]
        [TestCase(5, "2021/11/6", "Address1", "Medicine")]
        public void CreateCartonDetail_WhenCalled_CreatesAndReturnCartonObject(int medicineStripCount,DateTime launchDate, string retailerAddress, string key)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(key);
            
           CartonDetail result= p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
           Assert.That(result.MedicineStripCount, Is.EqualTo(medicineStripCount));

        }

        [Test]
        [TestCase(-5, "2022/11/6", "Address1", "Medicine")]
        [TestCase(-1, "2022/6/7", "Address1", "Medicine")]
        public void CreateCartonDetail_WhenCalledWithNegativeStripCount_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(key);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect strip count. Please check", exception.Message);

        }

        [Test]
        [TestCase(5, "2020/11/6", "Address1", "Medicine")]
        [TestCase(1, "2021/3/7", "Address1", "Medicine")]
        public void CreateCartonDetail_WhenCalledWithLaunchDateLessThanCurrentDate_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(key);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);

        }

        [Test]
        [TestCase(5, "2022/12/6", "Address1", "Medicine")]
        [TestCase(10, "2023/6/7", "Address1", "Medicine")]
        public void CreateCartonDetail_WhenCalledWithLaunchDateGreaterThanExpiryDate_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(key);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Launch date greater than expiry date. Please check", exception.Message);

        }

        [Test]
        [TestCase(5, "2022/11/6", "", "Medicine")]
        [TestCase(5, "2022/6/7", null, "Medicine")]
        public void CreateCartonDetail_WhenCalledWithNullOrEmptyAddress_ThrowsException(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(key);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect retailer address. Please check", exception.Message);

        }

        [Test]
        [TestCase(5, "2022/11/6", "Address1", "Empty")]
        [TestCase(5, "2022/6/7", "Address1", "Empty")]
        [TestCase(5, "2021/11/6", "Address1", "Empty")]
        public void CreateCartonDetail_WhenCalledWithEmptyMedicine_ReturnsEmptyCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress, string key)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(key);

            CartonDetail result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(result, Is.EqualTo(null));

        }
    }
}
