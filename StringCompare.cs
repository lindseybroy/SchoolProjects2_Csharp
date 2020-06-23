using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_CS317_U2_Guided_2
{
    class StringCompare
    {
       public static void Main(string[] args)
        {
            string string1 = "hello";
            string string2 = "good bye";
            string string3 = "Happy Birthday";
            string string4 = "happy birthday";

            Console.WriteLine("string1=\"" + string1 + "\"" + "\nstring2=\"" + string2 + "\"" + "\nstring3 = \"" + string3 + "\"" + "\nstring4 =\"" + string4 + "\"\n");

            if (string1.Equals("hello"))
                Console.WriteLine("string1 equals \"hello\"");
            else
                Console.WriteLine("string1 does not equal \"hello\"");

            if (string1 == "hello")
                Console.WriteLine("string1 equals \"hello\"");
            else
                Console.WriteLine("string1 does not equal\"hello\"");

            if (string.Equals(string3, string4))
                Console.WriteLine("string3 equals string4");
            else
                Console.WriteLine("string3 does not equal string4");

            Console.WriteLine("\nstring1.Compare to(string2) is ", +
                string1.CompareTo(string2) + "\n" +
                "string2.CompareTo(string1) is" +
                string2.CompareTo(string1) + "\n" +
                "string1.CompareTo(string1) is" +
                string1.CompareTo(string1) + "\n" +
                "string2.CompareTo(string4) is" +
                string3.CompareTo(string4) + "\n" +
                "string4.CompareTo(string3) is " +
                string4.CompareTo(string3) + "\n\n"); 

        
        }
    }
}
