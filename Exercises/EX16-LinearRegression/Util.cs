using System;
using System.Collections.Generic;

namespace EX16_LinearRegression
{
    class Util
    {
        public static int NumofPoints(List<int> weight)
        {
            int n = 0;
            foreach (var w in weight)
                n++;
            Console.WriteLine($"n {n}");
            return n;
        }

        public static int SumX(List<int> height, int sum)
        {
            foreach(var h in height)
                sum += h;
            Console.WriteLine($"sumx {sum}");
            return sum; 
        }

        public static int SumXSq(List<int> height, int sum)
        {
            foreach (var h in height)
                sum += (int)Math.Pow(h, 2);
            Console.WriteLine($"Xsq {sum}");
            return sum; 
        }

        public static int SumY(List<int> weight, int sum)
        {
            foreach (var w in weight)
                sum += w;
            Console.WriteLine($"sumy {sum}");
            return sum; 
        }

        public static int SumXY(int X, int Y, int sum)
        {
            sum = X * Y; 
            Console.WriteLine($"sum xy {sum}");
            return sum; 
        }

        public static int Alpha(int x, int xSqrd, int y, int xY, int n)
        {
            int A = ((y * xSqrd) - (x * xY)) / ((n * xSqrd) - (x * x));
            Console.WriteLine($"a {A}");
            return A; 
        }

        public static int Beta(int x, int xSqrd, int y, int xY, int n)
        {
            int B = ((n * xY) - (x * y)) / ((n * xSqrd) - (x * x));
            Console.WriteLine($"b {B}");
            return B; 
        }

        public static void GuessWeight(int input, int A, int B)
        {
            int output = A + (B * input);
            Console.WriteLine($"weight: {output}");
        }
    }
}
