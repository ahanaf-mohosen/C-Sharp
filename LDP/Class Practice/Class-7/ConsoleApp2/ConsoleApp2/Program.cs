using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Suppose you are a fruit shop owner. Now, 
              Create a class with the name of “Fruit” 
              
              Where you have to keep few fields such as 
              1. FruitName (string) 
              2. FruitColor(string) 
              3. NumberOfFruit (int) 

              Keep few methods in this class: 
              1. AddFruitNumber(int number) 
              2. RemoveFruit(int number)
            
              Task:  
              1. Initialize the fruit class for Mango.  
              2. Add 5 mangoes for Mango Class. 
              3. Initialize the fruit class 2nd time for Banana. 
              4. Add 3 bananas for Banana Class. 
              5. Remove 3 mangoes from Mangoes class. 
              6. Remove 2 bananas from Banana class. 
              7. Print all data of Mangoes. 
              8. Print all data for Bananans.
            */

            Fruit Mango = new Fruit();
            Mango.FruitName = "Mango";
            Mango.FruitColor = "Mix red & yellow";
            Mango.NumberOfFruit = 0;

            Mango.AddFruitNumber(5);

            Fruit Banana = new Fruit();
            Banana.FruitName = "Banana";
            Banana.FruitColor = "Yellow";
            Banana.NumberOfFruit = 0;

            Banana.AddFruitNumber(3);

            Mango.RemoveFruitNumber(3);
            Banana.RemoveFruitNumber(2);

            // Print all data for Mangoes
            Console.WriteLine("Mangoes:");
            Console.WriteLine("Fruit Name: " + Mango.FruitName);
            Console.WriteLine("Fruit Color: " + Mango.FruitColor);
            Console.WriteLine("Number of Fruit: " + Mango.NumberOfFruit);

            // Print all data for Bananas
            Console.WriteLine("Bananas:");
            Console.WriteLine("Fruit Name: " + Banana.FruitName);
            Console.WriteLine("Fruit Color: " + Banana.FruitColor);
            Console.WriteLine("Number of Fruit: " + Banana.NumberOfFruit);

            Console.ReadLine();
        }
    }
}
