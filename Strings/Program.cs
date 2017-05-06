using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {


            string firstName = "Drake"; //keyword
            //var firstName = "Drake";
            String lastName = "Scott"; //class
            //var

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is : {0} {1}", firstName, lastName);

            var names = new string[3] {"john", "jack", "mary"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            //var text = "Hi Drake\nLook into the following path\nc:\\folder\\folder2\nc:\\folder3\\folder4";
            var text = @"Hi Drake 
Look into the following path
c:\folder\folder2
c:\folder3\folder4";
            Console.WriteLine(text);

        }
    }
}
