using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit;
using NUnit.Framework;

namespace MyFoodSupplyTest
{
    [TestFixture]
    public class Test
    {
        Program p;
        FoodDetail foodItem;
        [SetUp]
        public void Setup()
        {
            p = new Program();
            foodItem = new FoodDetail()
            {
                Name = "Salad",
                DishType = (FoodDetail.Category)3,
                ExpiryDate = new DateTime(2022, 01, 01),
                Price = 30.50
            };
        }

        //Check if the medicine object food item gets created successfully on providing all correct detail
        [Test]
        [TestCase("Salad",3,"01/01/2022",30.50)]
        public void CreateFoodDetail_MethodCall_ObjectCreation(string name, int dishType, DateTime expiryDate, double price)
        {
            var result = p.CreateFoodDetail(name, dishType, expiryDate, price);

            Assert.That(result, Is.TypeOf<FoodDetail>());
            Assert.AreEqual(result.Name, name);
            Assert.AreEqual(result.DishType, (FoodDetail.Category)dishType);
            Assert.AreEqual(result.ExpiryDate, expiryDate);
            Assert.AreEqual(result.Price, price);
        }

        //Check if exception is thrown on providing empty value for Generic Medicine Food item name
        [Test]
        [TestCase("", 3, "01/01/2022", 30.50)]
        public void CreateFoodDetail_EmptyName_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name,dishType,expiryDate,price));
        }

        //Check if exception is thrown on providing value less than 0 for price per strip
        [Test]
        [TestCase("Salad", 3, "01/01/2022", -10)]
        public void CreateFoodDetail_PriceLessThanZero_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        //Check if exception is thrown on providing date less than current date for expiry date parameter
        [Test]
        [TestCase("Salad", 3, "01/01/2021", -10)]
        public void CreateDetail_ExpiryDateLessThanCurrentDate_Exception(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
        }

        //Check if the Carton Supply detail object gets created successfully on providing all correct detail
        [Test]
        [TestCase(5, "2021-05-01", "abc", 5)]
        public void CreateSupplyDetail_MethodCall_ObjectCreation(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            var result = p.CreateSupplyDetail(foodItemCount,requestDate,sellerName,packingCharge,foodItem);

            Assert.That(result, Is.TypeOf<SupplyDetail>());
            Assert.AreEqual(foodItemCount, result.Count);
            Assert.AreEqual(requestDate, result.RequestDate);
            Assert.AreEqual(sellerName, result.SellerName);
            Assert.AreEqual((foodItem.Price * foodItemCount + packingCharge), result.TotalCost);
        }

        //Check if exception is thrown on providing value less than 0 for food item count.
        [Test]
        [TestCase(-5, "2021-05-01", "abc", 5.50)]
        public void CreateSupplyDetail_FoodCountLessThanZero_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        //Check if exception is thrown on providing request date less than current date for launch date parameter
        [Test]
        [TestCase(-5, "2021-01-01", "abc", 5.50)]
        public void CreateSupplyDetail_RequestDateLessThanCurrentDate_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem));
        }

        //Check if null value provided for food item object, then Null carton supply detail should be obtained
        [Test]
        [TestCase(5, "2021-01-01", "abc", 5.50, null)]
        public void CreateSupplyDetail_NullFoodItemObject_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, FoodDetail foodItem)
        {
            var result = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, foodItem);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
