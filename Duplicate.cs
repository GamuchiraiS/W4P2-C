using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public class Duplicate
    {
        //fields
        public int[] valueArray;
        public int amountOfDuplicNums; 
        //constructor
        public Duplicate(int [] arr)
        {
            valueArray = arr;
            amountOfDuplicNums = 0;

        }
   
        //method for determining the duplicates numbers
        public int AmountDupNums(int [] valueArray)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int x = i + 1; x < 10; x++)
                {
                    //If a duplicate of the element is found, 
                    //incremnt amountOfDuplicNums
                    if (valueArray[i] == valueArray[x])
                    {
                        amountOfDuplicNums++;
                        break;
                        //return amountOfDuplicNums;
                    }
                }
            }
            return amountOfDuplicNums;

        }
    }
}
