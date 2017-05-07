using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
//            int[] numbers = new int[3];
//            //var numbers = new int[3];
//            numbers[0] = 1;
//
//            Console.WriteLine(numbers[0]);
//            Console.WriteLine(numbers[1]);
//            Console.WriteLine(numbers[2]);
//
//            var flags = new bool[3];
//            flags[0] = true;
//
//            Console.WriteLine(flags[0]);
//            Console.WriteLine(flags[1]);
//            Console.WriteLine(flags[2]);
//
//            var names = new string[3] {"jack", "john", "Ellie"};

            var numbers = new[] { 3, 7, 9, 2, 14, 6};

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy()

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var number in another)
            {
                Console.WriteLine(number);
            }

            //Sort()
            Array.Sort(another);
            Console.WriteLine("Effect of Sort()");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
