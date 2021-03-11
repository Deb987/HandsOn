using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericMedicine;
using NUnit;
using NUnit.Framework;

namespace GenericMedicineTest
{
    [TestFixture]
    public class Test
    {
        Program p;
        Medicine m;

        [SetUp]
        public void SetUp()
        {
            p = new Program();
            m = new Medicine() { Name = "Raj", GenericMedicineName = "abc", Composition = "xyz", ExpiryDate = DateTime.Parse("12-03-2022"), PricePerStrip = 100 };
        }

        //Check if the medicine object gets created successfully on providing all correct detail
        [Test]
        [TestCase("Raj", "abc", "xyz", "12/03/2022", 100)]
        public void MedicineObjectCreationTest(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            var result = p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);
            Assert.That(result, Is.TypeOf<Medicine>());
            Assert.AreEqual(result.Name, name);
            Assert.AreEqual(result.GenericMedicineName, genericMedicineName);
            Assert.AreEqual(result.Composition, composition);
            Assert.AreEqual(result.ExpiryDate, expiryDate);
            Assert.AreEqual(result.PricePerStrip, pricePerStrip);
        }

        //Check if exception is thrown on providing empty value for Generic Medicine name.
        [Test]
        [TestCase("Raj", null, "xyz", "2022-03-01", 100)]
        public void MedicineNameEmptyTest(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        //Check if exception is thrown on providing value less than 0 for price per strip.
        [Test]
        [TestCase("Raj", "abc", "xyz", "2022-03-01", -100)]
        public void LessThanZeroPriceTest(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        //Check if exception is thrown on providing date less than current date for expiry date parameter
        [Test]
        [TestCase("Raj", "abc", "xyz", "2021-03-01", 100)]
        public void ExpiryDateTest(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        //Check if the Carton object gets created successfully on providing all correct detail
        [Test]
        [TestCase(5, "2022-03-01", "Mumbai")]
        public void CartoonObjectCreationTest(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {

            var result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);

            Assert.That(result, Is.TypeOf<CartonDetail>());
            Assert.AreEqual(result.MedicineStripCount, medicineStripCount);
            Assert.AreEqual(result.LaunchDate, launchDate);
            Assert.AreEqual(result.RetailerAddress, retailerAddress);
        }

        //Check if exception is thrown on providing value less than 0 for medicine strip count.
        [Test]
        [TestCase(-5, "2022-03-01", "Mumbai")]
        public void LessThanZeroStripCountTest(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {

            Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
        }

        //Check if exception is thrown on providing date less than current date for launch date parameter
        [Test]
        [TestCase(5, "2021-03-01", "Mumbai")]
        public void LaunchDateTest(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {

            Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
        }

        //Check if null value provided for Medicine object, then Null carton detail should be obtained
        [Test]
        [TestCase(5, "2022-03-01", "Mumbai", null)]
        public void NullCartonTest(int medicineStripCount, DateTime launchDate, string retailerAddress, Medicine med)
        {
            var result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med);

            Assert.That(result, Is.EqualTo(null));
        }

    }
}
