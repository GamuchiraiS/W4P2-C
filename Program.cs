using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args) {
            int[] valueArray = new int[10];
            //Asking user to enter 
            Console.WriteLine("Please enter integer values: ");

            for (int i = 0; i < 10; i++)
            {
                //allows user to enter numbers 
                Console.WriteLine("Number {0}: ", i);
                //store values in array
                valueArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Duplicate dup = new Duplicate(valueArray);
            dup.AmountDupNums(dup.valueArray);
            Console.WriteLine("Amount of duplicate numbers: " + dup.amountOfDuplicNums);
            Console.ReadLine();
        }
    }
}
