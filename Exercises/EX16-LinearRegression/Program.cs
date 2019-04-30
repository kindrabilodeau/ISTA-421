using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16_LinearRegression
{
    class Program
    {
        //Input a height and it should guess the weight 
        static void Main(string[] args)
        {
            List<int> weight = new List<int> { 165, 185, 190, 210, 180, 180, 160}; //y
            List<int> height = new List<int> { 66, 71, 70, 72, 72, 66, 67};   //x
            //List<int> weight = new List<int> { 8, 10, 12, 15, 20 };
            //List<int> height = new List<int> { 12, 8, 22, 5, 17 };
           
            int sum = 0; 
            int X = Util.SumX(height,sum);
            int XSqrd = Util.SumXSq(height, sum);
            int Y = Util.SumY(weight, sum);
            int XY = Util.SumXY(X, Y, sum);
            int n = Util.NumofPoints(weight);
 
                
            int a = Util.Alpha(X, XSqrd, Y, XY, n);
            int b = Util.Beta(X, XSqrd, Y, XY, n);
            
            Console.Write("Input a height in inches: ");
            int inputa = int.Parse(Console.ReadLine());
            Util.GuessWeight(inputa, a, b); 
            Console.ReadLine();

            
            int x = height.Sum();
            int x2 = height.Sum() * height.Sum();
            int y = weight.Sum();
            int xy = weight.Sum() * height.Sum();
            int N = height.Count();
            

            Console.WriteLine($"x {x} x2 {x2} y {y} xy {xy} N {N}");
            Console.Write("Input a height in inches: ");
            int input = int.Parse(Console.ReadLine());

            int A = ((y * x2) - (x * xy)) / ((N * x2) - (x * x));
            int B = ((N * xy) - (x * y)) / ((N * x2) - (x * x));
            Console.WriteLine($"a {A} b {B}");
            int line = A + (B * input);
          
            Console.WriteLine($"Weight: {line}");
            Console.ReadLine();

        }
    }
}
