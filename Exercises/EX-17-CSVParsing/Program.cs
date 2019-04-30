using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17_CSVParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //no math just string manipulation
            /*************************
            * read CSV with embedded commas
            * parse CSV into separate fields and
            * ignore commas within quoted string
            * ***********************/
            Console.WriteLine("Reading CSV with embedded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
            "\"Ft. Stewart, Georgia\",31.8691N, 81.6090W," +
            "\"Ft. Gordon, Georgia\",33.4302N, 82.1267W";
            myList.Add(input3);

            foreach (string s in myList)
            {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                    Console.WriteLine(s1);
            }
            Console.ReadLine();
        }

        private static List<string> getCSV(string s)
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
            string item = "";
            int len = s.Length;
            char quote = '"';
            char comma = ',';
            bool quoteFlag = false;
            bool commaFlag = false;

            for (int i = 0; i < len; i++)
            {
                if (s[i] == quote)
                {
                    quoteFlag = true;  //turn on quotes
                    i++;    //skip the quote 
                    while (quoteFlag == true)
                    {
                        if (s[i] == quote || i == len)       //check for second quote or end of string
                        {
                            quoteFlag = false;   //turn quotes back off
                            item = sb.ToString(); //change back to string
                            list.Add(item);      //add string to list 
                            sb.Clear();          //reset sb for next iteration 
                        }
                        else
                        {
                            sb.Append(s[i]);
                            i++;
                        }
                    }
                }

                else if (s[i] == comma)
                {
                    i++;       //add one to skip the comma 
                    if (s[i] != quote) //if next one is not quote 
                        commaFlag = true;
                    if (s[i] == quote)  //if next one is quote 
                    {
                        quoteFlag = true;  //turn on quotes
                        i++;    //skip the quote 
                        while (quoteFlag == true)
                        {

                            if (s[i] == quote || i == len)  //check for second quote or end of string
                            {
                                quoteFlag = false;   //turn quotes back off
                                item = sb.ToString(); //change back to string
                                list.Add(item);      //add string to list 
                                sb.Clear();          //reset sb for next iteration 
                            }
                            else
                            {
                                sb.Append(s[i]);
                                i++;
                            }
                        }
                    }
                    while (commaFlag == true)
                    {
                        if (s[i] == comma) //looks for second comma 
                        {
                            commaFlag = false;   //turn comma's off
                            item = sb.ToString(); //change back to string
                            list.Add(item);      //add string to list 
                            sb.Clear();          //reset sb for next iteration 
                        }
                        else
                        {
                            sb.Append(s[i]);
                            if (i + 1 == len)   //checks for the end of the string 
                            {
                                commaFlag = false;    //turn comma's off
                                item = sb.ToString(); //change back to string
                                list.Add(item);      //add string to list 
                                sb.Clear();          //reset sb for next iteration 
                            }
                            else
                                i++;
                        }
                    }
                }
            }

            return list;
        }
    }
}
