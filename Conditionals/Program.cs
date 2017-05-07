using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
//            int hourt = 10;
//
//            if (hourt > 0 && hourt < 12)
//            {
//                Console.WriteLine("It's morning.");
//            }
//            else if (hourt >= 12 && hourt < 18)
//            {
//                Console.WriteLine("It's afternoon.");
//            }
//            else
//            {
//                Console.WriteLine("It's evening.");
//            }

//            bool isGoldCustomer = true;

//            float price;
//            if (isGoldCustomer)
//                price = 19.95f;
//            else
//            {
//                price = 29.95f;
//            }

//            float price = (isGoldCustomer) ? 19.95f : 29.95f;
//
//            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                //if autumn or summer, it will dispaly "it's peerfect to go to the beach"
//                case Season.Autumn:
//                case Season.Summer:
//                    Console.WriteLine("It's perfect to go to beacn.");
//                    break;
                case Season.Autumn:
                        Console.WriteLine("It's autumn and a beautiful season.");
                        break;
                    case Season.Summer:
                        Console.WriteLine("It's perfect to go to the beach.");
                        break;
                    default:
                        Console.WriteLine("I don't understand that season!");
                        break;
            }

        }
    }
}
