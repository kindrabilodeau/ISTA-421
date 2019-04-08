using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_VectorDistance
{
    class Util
    {
        //Fills the the array with random numbers 
        public static Cords[] FillArray(Cords[] cord)
        {
            Random randy = new Random();
            for (int i = 0; i < cord.Length; i++)
            {
                cord[i].x = randy.Next(1, 101);
                cord[i].y = randy.Next(1, 101);
            }
            //This is here to check the array
            //foreach (var c in cord)
            //   Console.Write($"Cords({c.x},{c.y}), ");
            return cord;
        }

        public static double FindDistance(Cords[] c)
        {
            double value;
            double max = Int32.MaxValue;

            for (int i = 0; i < c.Length; i++)
                for (int j = i + 1; j < c.Length; j++)
                {
                    value = Math.Sqrt(Math.Pow(c[i].x - c[j].x, 2) + Math.Pow(c[i].y - c[j].y, 2));
                    if (value < max)
                    {
                        max = value;
                        Console.Write($"The closest points are at element {i},{j}: ");
                        Console.Write($"({c[i].x},{c[i].y})({c[j].x},{c[j].y})");
                        Console.WriteLine($"With A Distance:{value}");
                        Console.WriteLine();
                    }

                }
            return max;
        }

        public static Cords[] FillArray3Point(Cords[] cords)
        {
            Random randy = new Random();
            for (int i = 0; i < cords.Length; i++)
            {
                cords[i].x = randy.Next(1, 1001);
                cords[i].y = randy.Next(1, 1001);
                cords[i].z = randy.Next(1, 1001);
            }
            //foreach (var c in cords)
            //   Console.Write($"Cords({c.x},{c.y},{c.z}), ");
            return cords;
        }

        public static void Distance3Point(Cords[] c)
        {
            double value;
            double max = Int32.MaxValue;
            for (int i = 0; i < c.Length; i++)
                for (int j = i + 1; j < c.Length; j++)
                {
                    value = Math.Sqrt(Math.Pow(c[i].x - c[j].x, 2) + Math.Pow(c[i].y - c[j].y, 2) + Math.Pow(c[i].z - c[j].z, 2));
                    if (value < max)
                    {
                        max = value;
                        Console.Write($"The closest points are at element {i},{j}: ");
                        Console.WriteLine($"({c[i].x},{c[i].y},{c[i].z})({c[j].x},{c[j].y},{c[j].z})");
                        Console.WriteLine($"With A Distance of:{value}");
                        Console.WriteLine();
                    }
                }
        }
    }
}
