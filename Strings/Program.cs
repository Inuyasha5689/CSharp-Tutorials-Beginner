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


//            string firstName = "Drake"; //keyword
//            //var firstName = "Drake";
//            String lastName = "Scott"; //class
//            //var
//
//            var fullName = firstName + " " + lastName;
//
//            var myFullName = string.Format("My name is : {0} {1}", firstName, lastName);
//
//            var names = new string[3] {"john", "jack", "mary"};
//            var formattedNames = string.Join(",", names);
//            Console.WriteLine(formattedNames);
//
//            //var text = "Hi Drake\nLook into the following path\nc:\\folder\\folder2\nc:\\folder3\\folder4";
//            var text = @"Hi Drake 
//Look into the following path
//c:\folder\folder2
//c:\folder3\folder4";
//            Console.WriteLine(text);

            //String PART 2
            var fullName = "Drake Scott ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("lastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Drake", "Dragon"));
            
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
            
        }
    }
}
