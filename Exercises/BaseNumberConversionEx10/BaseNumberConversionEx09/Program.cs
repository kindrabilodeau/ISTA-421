using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConversionEx10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter The Integer To Convert:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please Enter The Base To Convert From 2|8|10:");
            int from = int.Parse(Console.ReadLine());

            Console.WriteLine($"Number:{number}, Base:{from}");

           // int result = 0;

            if (from == 10)
            {
                Util.Dec2Bin(number);
                Util.Dec2Oct(number); 
            }
            else if (from == 2)
            {
                Util.Bin2Dec(number);
                Util.Bin2Oct(number);

            }
            else if (from == 8)
            {
                Util.Oct2Bin(number);
                Util.Oct2Dec(number);
            }
            else
                Console.WriteLine("Error in base to convert from ");
        }
    }
}
