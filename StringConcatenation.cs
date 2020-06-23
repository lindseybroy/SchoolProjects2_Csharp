using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_CS317_U1_Guided_4
{
    class StringConcatenation
    {
        public static void Main(string[] args)
        {
            string string1 = "Happy";
            string string2 = "Birthday";

            Console.WriteLine("string1 = \"" + string1 + "\"\n" + "string2 =\"" + string2 + "\"");
            Console.WriteLine("\nResult of string.Concat(string1, string2) =" +
                string.Concat(string1, string2));
            Console.WriteLine("string1 after concatenation=" + string1); 
        }
    }
}
