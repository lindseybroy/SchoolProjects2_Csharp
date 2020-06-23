using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS317_U5_Guided2_Roy
{
    public class SumArray
    {
        public static void Main(string[] args)
        {
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            for (int counter = 0; counter < array.Length; ++counter)
                total += array[counter];

            Console.WriteLine("Total of array elements: {0}", total);
        }
    }
}
