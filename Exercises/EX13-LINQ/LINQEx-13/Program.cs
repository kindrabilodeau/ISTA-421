using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEx_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1: Print the Even Numbers in a list 
            int[] n1 = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var query1 =
                from n in n1
                where (n % 2) == 0
                select n;
            Console.WriteLine("The Even Numbers Are: ");
            Print(query1);

            //#2: Print the positive numbers in a list
            int[] n2 = new int[13] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var query2 =
                from n in n2
                where n > 0 && n < 12
                select n;
            Console.WriteLine("The Postive Numbers Are: ");
            Print(query2);

            //#3: Print the Squares over 20
            var n3 = new int[6] { 3, 9, 2, 8, 6, 5 };
            var query3 =
                from n in n3
                where (n * n) > 20
                select n;
            Console.WriteLine("The Squared Numbers over 20 are: ");
            foreach (int que in query3)
                Console.WriteLine($"Number:{que}, SqrNum:{que * que}");
            Console.WriteLine();

            //#4: Number of Times A Digit Appears: 
            int[] n4 = new int[18] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var query4 =
                from n in n4
                group n by n into numgroup
                select numgroup;
            Console.WriteLine("The Frequency of the Characters Are:");
            foreach (var que in query4)
                Console.WriteLine($"Number {que.Key} appears {que.Count()} times");

            //#5: Count The Number of Seperate Characters In A String 
            string words = "Hello, I am a string. How do you like me? ";
            var query5 =
                from word in words
                group word by word into wordgroup
                select wordgroup;
            Console.WriteLine("The Frequency of the characters are: ");
            foreach (var que in query5)
                Console.WriteLine($"Character {que.Key}: {que.Count()} times");
            Console.WriteLine();

            //#6: Print The days of the week 
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            var query6 =
                from day in dayWeek
                select day;
            Console.WriteLine("Days of the Week:");
            foreach(var que in query6)
                Console.WriteLine($"{que}");
            Console.WriteLine();

            //#7: Digit, Frequency, Number * Frequency
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var query7 =
                from n in nums
                group n by n into numgroup
                select numgroup;

            Console.WriteLine("Number|Frequency|Number * Frequency");
            Console.WriteLine("------------------------------------------");
            foreach(var que in query7)
                Console.WriteLine($"{que.Key}         {que.Count()}" +
                    $"              {que.Key * que.Count()} ");
            Console.WriteLine();
         
      /*
          
            //#8: Beginning and Ending Characters
            string[] cities = {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI",
            "AMSTERDAM", "ABU DHABI", "PARIS"};
            Console.WriteLine("The cities are: ");
            foreach(string c in cities)
                Console.WriteLine($"{c}, ");
            Console.Write("Input first character for the city name: ");
            string start = Console.ReadLine().ToUpper();
            Console.Write("Input the last character the city name: ");
            string end = Console.ReadLine().ToUpper();
            var query8 =
                from c in cities
                where c.StartsWith(start) && c.EndsWith(end)
                select c;
            Console.WriteLine($"Cities that start with {start} and end with {end} are ");
            foreach(var que in query8)
                Console.WriteLine($"{que}");

    */

            //#9: Create a list and print larger values 

            //Ask user for the top N values
            //For 3N: 50,21,13
            int[] arr = new int[] { 5, 13, 4, 21, 2, 6, 9, 50 };
            Console.WriteLine("Enter the number of top values to display");
            string input = Console.ReadLine();
            int topValues = int.Parse(input);
            var query10 = //linq query 
                 from a in arr
                 orderby a descending
                 select a; 

            Console.WriteLine($"The top {topValues} values are:"); 
            foreach(int q in query10)
                Console.WriteLine($"{q}");

        }

        private static void Print(IEnumerable<int> query)
        {
            foreach (int que in query)
                Console.Write($"{que}, ");
            Console.WriteLine();
        }
    }
}
