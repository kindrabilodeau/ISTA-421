using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConversionEx10
{
    //Reflection:After writing this and looking back. If I had 
    //Had my methods return values I could have 
    //1.Called methods in other methods
    //2.My code would have looked much cleaner and had the writelines
    //only in the program class
    class Util
    {
        //Converts a decimal number to binary 
        //Takes input number divides by two
        //Takes input number and gets modulus two 
        //The new number is the one that was divided by two 
        // Each modulus is added to a list, then printed out 
        internal static void Dec2Bin(int number)
        {
            int bine = 0;
            List<int> list = new List<int>();
            while (number >= 1)
            {
                int div = number / 2;
                bine = number % 2;
                number = div;
                list.Add(bine);
            }
            Console.Write($"Decimal to Binary:");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write($"{list[i]}");
            }
            Console.WriteLine();
        }

        //Takes a decimal number and converts to octal 
        //Takes input number divides it by 8
        //Take input number and gets modulus 89
        //The new number is the one that has been divded by 8
        //Each modulus is added to a list and printed out 
        internal static void Dec2Oct(int number)
        {
            int oct = 0;
            List<int> octList = new List<int>();
            while (number >= 1)
            {
                int div = number / 8;
                oct = number % 8;
                number = div;
                octList.Add(oct);
            }
            Console.Write($"Decimal to Octal:");
            for (int i = octList.Count - 1; i >= 0; i--)
            {
                Console.Write($"{octList[i]}");
            }
            Console.WriteLine();
        }

        //Takes a Binary number and converts it to Decimal: 
        //Created array for the (decimal?? locations???) --dont know the correct terms for this
        //Iterate through the binary input number using a for loop
        //Modulus 10 for the last number
        //Get the current (decimal location) and add it to each one 
        //Divide number by 10 to discard the last number 
        internal static void Bin2Dec(int number)
        {
            int[] bin = new int[7] { 1, 2, 4, 8, 16, 32, 64 }; //what do you call these?
            int len = number.ToString().Length; //Length of the binary input number
            int total = 0;
            for (int i = 0; i < len; i++)
            {
                int last = number % 10; //gets last digit in number
                if (last == 1)
                    total = total + bin[i]; //gets (decimal location) and add it too the previous one
                number = number / 10; //discards the last number,shortens the input num by 1 (ex:101 -> 10)
            }
            Console.Write($"Binary to Decimal:");
            Console.Write($"{total}");
            Console.WriteLine();
        }

        //Takes an Octal number converts to a Decimal number:
        //Create an array with the (octal locations??) --what's the term for this?
        //Iterate through the input number
        //Use %10 to get last number, Divide by 10 to discard last number
        //Multiply the last number by the element in the array 
        //Add the sum - which add each iteration together
        internal static void Oct2Dec(int number) //123 = 443, 20 = 40 
        {
            int[] octarr = new int[6] { 1, 8, 64, 512, 4096, 262144 };
            int sum = 0;
            int len = number.ToString().Length;
            for (int i = 0; i <= len; i++)
            {
                int lastnum = number % 10; //to get the last digit in the number
                number = number / 10;      //discard last number
                sum = (lastnum * octarr[i]) + sum; //ex:number=515, lastnum = 5,ex:first time through = (5 * 1) + 0
            }
            Console.Write($"Octal to Decimal: ");
            Console.Write($"{sum}");
            Console.WriteLine();
        }

        //Convert Binary to Octal: 

        internal static void Bin2Oct(int number)
        {
            Stack<int> stack = new Stack<int>();
            int[] binarry = new int[3] { 1, 2, 4 };
            int last = 0;
            int div = 0;
            int check = 0;
            int math = 0;
            while (number > 0)
            {
                while (check < 3) // This is get only 3 numbers
                    for (int i = 0; i < binarry.Length; i++)
                    {
                        last = number % 10; //to get last digit
                        div = number / 10; //get remove last digit from number 
                        number = div; //the new is now is shorter
                        if (last == 1)
                        {
                            math = math + binarry[i]; //to assign it to the index in the array
                        }
                        check++;
                    }
                stack.Push(math); //add it to the stack 
                math = 0; //reset math variable 
                check = 0; //reset check 
            }
            Console.Write("Binary to Octal:");
            foreach (int s in stack)
                Console.Write($"{s}");
            Console.WriteLine();
        }

        //Convert Octal to Binary --works
        //Gets the last digit using %10 
        //Converts to binary using mod2 and divide2
        //Uses check to ensure that 3 binary numbers are returns
        internal static void Oct2Bin(int number)
        {
            Stack<int> stack = new Stack<int>();
            int last = 0;
            int newNumber = 0;
            while (number >= 1)
            {
                last = number % 10; //Get last number 
                int check = 0;      //check is reset for each number
                while (last > 0 || check < 3)
                {
                    int mod = last % 2; //Converts to binary 
                    stack.Push(mod);    //add mod 2 to stack 
                    check++;            //adds to check
                    int div = last / 2;  //divide
                    last = div;          //repeat
                    if (last == 0 && check < 2) //this is to ensure sure that 3 bineary numbers return
                    {                           //this will add zeros in front 
                        stack.Push(0);          //add to check,ensures only 3 binary numbers are returned
                        check++;
                    }
                }
                newNumber = number / 10;      //number divided 
                number = newNumber;
            }
            Console.Write("Octal to Binary: "); //iterates through stack 
            foreach (int s in stack)
                Console.Write($"{s}");
        }
    }
}
