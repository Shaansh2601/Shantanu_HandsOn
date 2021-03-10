using MyFoodSupply;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFoodDetailTest
{
    [TestFixture]
    public class CreateFoodItemTests
    {

        [Test]
        [TestCase("Name1",1,"2022/8/3",20)]
        [TestCase("Name2",2, "2021/8/3", 120)]
        [TestCase("Name3",3,"2022/3/24", 920)]
        public void CreateFoodDetail_WhenCalled_CreateAndReturnFoodDetailObject(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            FoodDetail foodDetail= p.CreateFoodDetail(name,dishType,expiryDate,price);
            Assert.That(foodDetail.Name, Is.EqualTo(name));
            Assert.That((int)foodDetail.DishType, Is.EqualTo(dishType));
            Assert.That(foodDetail.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(foodDetail.Price, Is.EqualTo(price));
        }

        [Test]
        [TestCase("", 1, "2022/8/3", 20)]
        [TestCase(null, 2, "2021/8/3", 120)]
        public void CreateFoodDetail_WhenCalledWithEmptyOrNullName_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", 1, "2022/8/3", -20)]
        [TestCase("Name2", 2, "2021/8/3", -120)]
        public void CreateFoodDetail_WhenCalledWithPriceLessThanZero_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Name1", 1, "2020/8/3", 20)]
        [TestCase("Name2", 2, "2021/2/3", 120)]
        public void CreateFoodDetail_WhenCalledWithExpiryDateLessThanCurrentDate_ThrowsException(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}
