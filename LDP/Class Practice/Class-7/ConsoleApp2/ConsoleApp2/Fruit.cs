using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Fruit
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

        public string FruitName { get; set; }
        public string FruitColor { get; set; }
        public int NumberOfFruit { get; set; }

        public Fruit()
        {

        }

        public void AddFruitNumber(int number)
        {
            NumberOfFruit += number;
        }

        public void RemoveFruitNumber(int number)
        {
            if (NumberOfFruit >= number)
            {
                NumberOfFruit -= number;
            }
            else
            {
                Console.WriteLine("Error: Not enough fruits to remove.");
            }
        }
    }
}
