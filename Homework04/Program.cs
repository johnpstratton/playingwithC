using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DisplayAsterisks(20));

            Console.Write("Enter today\'s sales for store 1:");
            int store1 = (int.Parse(Console.ReadLine()) /100); // divide all user inpute by 100 to allow while loop to function properly

            Console.Write("Enter today\'s sales for store 2:");
            int store2 = (int.Parse(Console.ReadLine()) /100 ); // divide all user inpute by 100 to allow while loop to function properly

            Console.Write("Enter today\'s sales for store 3:");
            int store3 = (int.Parse(Console.ReadLine()) /100); // divide all user inpute by 100 to allow while loop to function properly

            Console.Write("Enter today\'s sales for store 4:");
            int store4 = (int.Parse(Console.ReadLine()) /100); // divide all user inpute by 100 to allow while loop to function properly

            Console.Write("Enter today\'s sales for store 5:");
            int store5 = (int.Parse(Console.ReadLine()) /100); // divide all user inpute by 100 to allow while loop to function properly
            Console.WriteLine();                                    //Insert Console.WriteLine() for a line break
            Console.WriteLine("SALES BAR CHART");
            Console.WriteLine("(Each * = $100)");
            Console.WriteLine("Store 1: " + DisplayAsterisks(store1)); // Return user values with DisplayAsterisks Method created
            Console.WriteLine("Store 2: " + DisplayAsterisks(store2)); // Return user values with DisplayAsterisks Method created
            Console.WriteLine("Store 3: " + DisplayAsterisks(store3)); // Return user values with DisplayAsterisks Method created
            Console.WriteLine("Store 4: " + DisplayAsterisks(store4)); // Return user values with DisplayAsterisks Method created
            Console.WriteLine("Store 5: " + DisplayAsterisks(store5)); // Return user values with DisplayAsterisks Method created





            Console.Read();
        }
        static string DisplayAsterisks(int num) // Specify Method to return a string of "*" characters
        {
            int count = 0; // initiate counter int 
            List<char> display = new List<char>(); // Create list to house asterisk characters

            char asterisk = '*'; //Specify character integers to insert into list
            string displayString; // initiate string variabe to concatenate all *
            string salesTooLow = "Sales were below 100";
            while (count < num)
            {
                if (num > 0.0 && num <= 1.0)
                {
                    return salesTooLow;
                }
                    display.Insert(count, asterisk);
                    count++;
            }
            displayString = String.Join("", display);
            return displayString;
        }
    }
}
