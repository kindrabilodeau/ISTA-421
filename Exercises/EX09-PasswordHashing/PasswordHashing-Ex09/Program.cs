using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHashing_Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM");
            
            int userResponse = 9;
            userResponse = Util.PrintUI(); 

            //this will check the userResponse 
            //And do the request action
            while (userResponse != 0)
            {
                if (userResponse == 1)
                {
                    Util.GetNewUser();
                    userResponse = Util.PrintUI();
                }
                else if (userResponse == 2)
                {
                    Util.AuthUser();
                    userResponse = Util.PrintUI();
                }
                else if (userResponse == 3)
                {
                    Util.PrintUsers();
                    userResponse = Util.PrintUI(); 
                }
                else if(userResponse == 5) //This is for testing #secret menu
                {
                    Util.TestMethod();
                    userResponse = Util.PrintUI(); 
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't understand what you wanted to do.");
                    userResponse = Util.PrintUI();
                }
            };
            Environment.Exit(0);
        }
    }
}
