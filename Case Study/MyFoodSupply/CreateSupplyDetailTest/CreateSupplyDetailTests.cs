using MyFoodSupply;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSupplyDetailTest
{
    [TestFixture]
    public class CreateSupplyDetailTests
    {
        private static FoodDetail GetFoodDetailObject(string s)
        {
            if (s.Equals("FoodItem"))
            {
                return new FoodDetail()
                {
                    Name = "Name1",
                    DishType = FoodDetail.Category.MainDish,
                    Price = 122,
                    ExpiryDate = new DateTime(2022, 12,31)
                };
            }
            else
            {
                return null;
            }

        }

        [Test]
        [TestCase(2,"2021/11/15","SellerName1",15,"FoodItem")]
        [TestCase(10, "2021/12/31", "SellerName2", 35, "FoodItem")]
        [TestCase(12, "2022/4/11", "SellerName3", 40, "FoodItem")]
        public void CreateSupplyDetail_WhenCalled_CreateAndReturnsSupplyDetailObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, string key)
        {
            FoodDetail foodDetail = GetFoodDetailObject(key);
            Program p = new Program();
            SupplyDetail supplyDetail= p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail);
            Assert.That(supplyDetail.Count, Is.EqualTo(foodItemCount));
            
        }

        [Test]
        [TestCase(-2, "2021/11/15", "SellerName1", 15, "FoodItem")]
        [TestCase(-10, "2021/12/31", "SellerName2", 35, "FoodItem")]
        [TestCase(-12, "2022/4/11", "SellerName3", 40, "FoodItem")]
        public void CreateSupplyDetail_WhenCalledWithFoodItemCountLessThanZero_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, string key)
        {
            FoodDetail foodDetail = GetFoodDetailObject(key);
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
            Assert.AreEqual("Incorrect food item count. Please check", exception.Message);

        }

        [Test]
        [TestCase(2, "2021/2/15", "SellerName1", 15, "FoodItem")]
        [TestCase(10, "2021/1/31", "SellerName2", 35, "FoodItem")]
        [TestCase(12, "2020/8/11", "SellerName3", 40, "FoodItem")]
        public void CreateSupplyDetail_WhenCalledWithRequestDateLessThanCurrentDate_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, string key)
        {
            FoodDetail foodDetail = GetFoodDetailObject(key);
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", exception.Message);

        }

        [Test]
        [TestCase(2, "2023/2/15", "SellerName1", 15, "FoodItem")]
        [TestCase(10, "2023/1/31", "SellerName2", 35, "FoodItem")]
        [TestCase(12, "2024/8/11", "SellerName3", 40, "FoodItem")]
        public void CreateSupplyDetail_WhenCalledWithRequestDateGreaterThanExpiryDate_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, string key)
        {
            FoodDetail foodDetail = GetFoodDetailObject(key);
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
            Assert.AreEqual("Request date greater than expiry date. Please check", exception.Message);

        }

        [Test]
        [TestCase(2, "2021/11/15", "", 15, "FoodItem")]
        [TestCase(10, "2021/12/31", null, 35, "FoodItem")]
        public void CreateSupplyDetail_WhenCalledWithNullOrEmptySellerName_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, string key)
        {
            FoodDetail foodDetail = GetFoodDetailObject(key);
            Program p = new Program();

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail));
            Assert.AreEqual("Incorrect seller name. Please check", exception.Message);

        }

        [Test]
        [TestCase(2, "2021/11/15", "SellerName1", 15, "Empty")]
        [TestCase(10, "2021/12/31", "SellerName2", 35, "Empty")]
        [TestCase(12, "2022/4/11", "SellerName3", 40, "Empty")]
        public void CreateSupplyDetail_WhenCalledWithNullFoodDetailObject_ThrowsException(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, string key)
        {
            FoodDetail foodDetail = GetFoodDetailObject(key);
            Program p = new Program();
            SupplyDetail supplyDetail = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodDetail);
            Assert.That(supplyDetail, Is.EqualTo(null));

        }
    }
}
