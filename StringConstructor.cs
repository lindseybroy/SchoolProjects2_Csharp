using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_CS317_U1_Graded_1
{
    class StringConstructor
    {
       public static void Main(string[] args)
        {
            char[] characterArray = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };
            string originalString = "Welcome to C# programming!";
            string string1 = originalString;
            string string2 = new string(characterArray);
            string string3 = new string(characterArray, 6, 3);
            string string4 = new string('C', 5);

            Console.WriteLine("string1=" + "\"" + string1 + "\"\n" + "string2=" + "\"" + string2 + "\"\n" + "string3=" + "\"" + string3 + "\"\n" + "string4=" + "\"" + string4 + "\"\n");

        }
    }
}
