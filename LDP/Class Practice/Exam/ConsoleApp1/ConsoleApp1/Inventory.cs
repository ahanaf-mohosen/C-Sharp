using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inventory : Car
    {

        public Inventory()
        {

        }

        public void AllCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.Make + car.Model + car.Year + car.Price);
            }
        }
    }
}
