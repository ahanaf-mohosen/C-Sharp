using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
              The customer id, name and unit consumed by the user should be taken from the keyboard and 
              display the total amount to pay to the customer. 
              The charge  are as follow: 
           
              
              Unit 	                                Charge/unit

              upto 199 	                            @1.20
              200 and above but less than 400 	    @1.50
              400 and above but less than 600 	    @1.80
              600 and above 	                    @2.00


              If bill exceeds Rs. 400 then a surcharge of 15% will be charged and 
              the minimum bill should be of Rs. 100/-

              Test Data : 
              1001 
              James 
              800 

              Expected Output : 
              Customer IDNO :1001 
              Customer Name :James 
              unit Consumed :800 
              Amount Charges @Rs. 2.00 per unit : 1600.00 
              Surchage Amount : 240.00 
              Net Amount Paid By the Customer : 1840.00 
            */

            Console.WriteLine("\n### Calculate and print the Electricity bill of a given customer ###\n");


            Console.Write("Enter Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter Units Consumed: ");
            double unitsConsumed = Convert.ToInt32(Console.ReadLine());
            double chargePerUnit, billAmount, surchargeAmount = 0;
            Console.WriteLine();

            if (unitsConsumed <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }
            billAmount = unitsConsumed * chargePerUnit;
            if (billAmount > 400)
            {
                surchargeAmount = billAmount * 0.15;
            }
            else if (billAmount < 100)
            {
                surchargeAmount = 100;
                Console.WriteLine($"Your total surcharge amount is {billAmount}. But you have to pay @Rs. 100 .");
            }
            Console.WriteLine($"Customer ID NO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Unit Consumed: {unitsConsumed}");
            Console.WriteLine($"Amount Charges @Rs. {chargePerUnit} per unit: {billAmount}");
            Console.WriteLine($"Surcharge Amount: {surchargeAmount}");
            Console.WriteLine($"Net Amount Paid By the Customer: {(billAmount + surchargeAmount)}");
            Console.ReadLine();
        }
    }
}

