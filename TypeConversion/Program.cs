using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;  //no data loss
            Console.WriteLine(i);

            //int z = 1000;
            //byte b = i; //no workie. Cannot implicitly convert. Must use casting/explicit convert
            //byte c = (byte) i;
            //Console.WriteLine(c); //data loss

            //Non compatible types
            //var number = "1234";
            //int Integer = Convert.ToInt32(number);
            //Console.WriteLine(Integer);

            try
            {
                string str = "true";
                bool boon = Convert.ToBoolean(str);
                Console.WriteLine(boon);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

           
        }
    }
}
