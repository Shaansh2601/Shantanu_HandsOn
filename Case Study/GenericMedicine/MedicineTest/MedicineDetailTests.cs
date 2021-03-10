using GenericMedicine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMedicineDetailTest
{
    [TestFixture]
    public class MedicineDetailTests  
    {
        [Test]
        [TestCase("Name1","G_Med_Name1","Comp1","2022/6/3",12)]
        [TestCase("Name2", "G_Med_Name2", "Comp2", "2023/11/13", 11.9)]
        [TestCase("Name3", "G_Med_Name3", "Comp3", "2021/11/6", 110.11)]
        public void CreateMedicineDetail_WhenCalled_CreateAndReturnMedicineObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();
            Medicine result= p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);
            
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
            Assert.That(result.Composition, Is.EqualTo(composition));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));
        }

        [Test]
        [TestCase("", "G_Med_Name1", "Comp1", "2022/6/3", 12)]
        [TestCase(null, "G_Med_Name2", "Comp2", "2023/11/13", 11.9)] 
        public void CreateMedicineDetail_WhenCalledWithEmptyName_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Medicine name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", "", "Comp1", "2022/6/3", 12)]
        [TestCase("Name2",null, "Comp2", "2023/11/13", 11.9)]
        public void CreateMedicineDetail_WhenCalledWithEmptyGenericMedicineName_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Generic Medicine name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", "G_med_Name1", "", "2022/6/3", 12)]
        [TestCase("Name2", "G_med_name2",null, "2023/11/13", 11.9)]
        public void CreateMedicineDetail_WhenCalledWithEmptyComposition_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Medicine composition cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", "G_med_Name1", "Comp1", "2022/3/7", -12)]
        [TestCase("Name2", "G_med_name2", "Comp2", "2023/11/13", -11.9)]
        public void CreateMedicineDetail_WhenCalledWithNegativePrice_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", "G_med_Name1", "Comp1", "2021/3/7", 12)]
        [TestCase("Name2", "G_med_name2", "Comp2", "2020/11/13", 11.9)]
        public void CreateMedicineDetail_WhenCalledWithDateLessThanCurrentDate_ThrowsException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}
