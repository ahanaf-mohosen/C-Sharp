using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Problem: Building a Car Inventory System
              Create a C# program to manage a car inventory system. 
              The program should have the following requirements:

              1. Create a Car class with the following properties: make, model, year, and price. 
              2. Implement a parameterized constructor in the Car class to initialize the properties
              3. Create an Inventory class that contains a list of Car objects.
              4. Implement methods in the the list of cars in the inventory.
                 Inventory class to add a car, remove a car, and display 
              5. Implement a menu-driven console application that allows users to interact 
                 with the car inventory system.

              * The menu should provide options to add a car, remove a car, and display the inventory. 
              * When adding a car, the user should be prompted to enter the car's details 
                (make, model, year, and price). 
              * When removing a car, the user should be prompted to enter the car's make and model. 
              * When displaying the inventory, the program should list all the cars with their details. 
              * The menu should continue to loop until the user chooses to exit the program.
              
              Your task is to implement the Car and Inventory classes according to the given requirements 
              and create a console application that utilizes these classes to manage the car inventory system.
            */


            Inventory inventory = new Inventory();
            Car suzuki = new Car();
            suzuki.Make = "India";
            suzuki.Model = "V3";
            suzuki.Year = 2017;
            suzuki.Price = 500000;

            Car tata = new Car();
            tata.Make = "India";
            tata.Model = "toto-G5";
            tata.Year = 2016;
            tata.Price = 150000;

            List<Car> build_Car = new List<Car>();
            build_Car.Add(tata);
            build_Car.Add(suzuki);
            build_Car.Remove(tata);
            build_Car.Remove(suzuki);

        }
    }
}
