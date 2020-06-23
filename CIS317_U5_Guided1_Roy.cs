using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS317_U5_GuidedPractice1_LindseyRoy
{
    public class InitArray
    {
        public static void Main(string[] args)
        {
            const int ARRAY_LENGTH = 10;  //create a named constant
            int[] array = new int[ARRAY_LENGTH]; //create array

            //calculate value for each array element
            for (int counter = 0; counter < array.Length; ++counter)
                array[counter] = 2 + 2 * counter;

            Console.WriteLine("{0} {1,8}", "Index", "Value"); //headings

            //output each array element's value
            for (int counter = 0; counter < array.Length; ++counter)
                Console.WriteLine("{0, 5} {1,8}", counter, array[counter]);
        }
    }
}
