using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikeshop
{
    public class Shop
    {
        private List<Bike> bikes = new List<Bike>();
        private int bikeID = 0;

        public List<Bike> CreateBike()
        {
            Bike newBike = new Bike(bikeID, "Name", 100);
            bikes.Add(newBike);
            return bikes;
        }

        public List<Bike> GetBikes()
        {
            return bikes;
        }

        public List<Bike> UpdateBike(int id, string newName)
        {
            bikes[id].name = newName;
            return bikes;
        }

        public List<Bike> DeleteBike(int id)
        {
            bikes.RemoveAt(id);
            return bikes;
        }
    }
}
