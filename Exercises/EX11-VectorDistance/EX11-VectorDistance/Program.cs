using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_VectorDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 11: Vector Distance Calculation");
            Cords[] cord = new Cords[100];
            cord = Util.FillArray(cord);   //fill array with random numbers
            Util.FindDistance(cord); //find distance between each point 
            Cords[] cords3 = new Cords[1000];
            
            cords3 = Util.FillArray3Point(cords3);
            Util.Distance3Point(cords3); 
        }
    }
}
