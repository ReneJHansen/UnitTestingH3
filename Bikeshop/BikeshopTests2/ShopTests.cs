using NUnit.Framework;
using Bikeshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikeshop.Tests
{
    [TestFixture()]
    public class ShopTests
    {
        List<Bike> bikes = new List<Bike>();
        Shop shop = new Shop();

        [Test()]
        public void CreateBikeTest()
        {
            Assert.That(bikes.Count == 0);
            bikes = shop.CreateBike();
            Assert.That(bikes.Count == 1);
        }

        [Test()]
        public void GetBikesTest()
        {
            for (int i = 0; i < 10; i++)
            {
                bikes = shop.CreateBike();
            }
            bikes = shop.GetBikes();
            Assert.That(bikes.Count == 10);
        }

        [Test()]
        public void UpdateBikeTest()
        {
            for (int i = 0; i < 10; i++)
            {
                bikes = shop.CreateBike();
            }
            shop.UpdateBike(3, "New Name");
            Assert.That(bikes[3].name, Is.EqualTo("New Name"));
        }

        [Test()]
        public void DeleteBikeTest()
        {
            for (int i = 0; i < 10; i++)
            {
                bikes = shop.CreateBike();
            }
            shop.DeleteBike(3);
            Assert.That(bikes.Count == 9);
            Console.WriteLine(bikes[3].id); // 0
        }
    }
}