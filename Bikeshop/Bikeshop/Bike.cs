using System;

namespace Bikeshop
{
    public class Bike
    {
        public int id;
        public string name;
        public int price;

        public Bike(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
