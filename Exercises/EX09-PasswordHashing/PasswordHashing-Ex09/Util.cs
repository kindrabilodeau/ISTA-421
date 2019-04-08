using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordHashing_Ex09
{
    class Util
    {
        static Dictionary<string, string> accounts = new Dictionary<string, string>();

        //This prints outs the menu options 
        //-----Do I want to change the exit number to 4?-----
        internal static int PrintUI()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Please Select One: \n" +
                "1. Establish an Account \n" +
                "2. Authenticate a User \n" +
                "3. Print All Users\n" +
                "0. Exit System");
            Console.Write("Enter Selection:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            return input;
        }

        // This gets a username and password
        // Checks username to ensure it's not already taken
        // Hashes out the password 
        // Then adds it to a dictionary 
        internal static void GetNewUser()
        {
            Console.Write("Enter UserName:");
            string user = Console.ReadLine();
            bool check = CheckUserName(user);
            if (check == false)
                GetNewUser(); 
            else
            {
                Console.Write("Enter Password:");
                string pass = Console.ReadLine();
                string hashedpass = HashItOut(pass);
                accounts.Add(user, hashedpass);
                Console.WriteLine("Account Created \n");
            }
        }

        //This was written to check the that the 
        //dictionary and hashing worked
        public static void TestMethod()
        {
            foreach(KeyValuePair<string,string> check in accounts)
                Console.WriteLine("Testing hashing & Dictionary KEY:{0} Value:{1}", check.Key , check.Value);
        }

        //Takes a string input (password)
        //'Hash's it out' using sha256
        private static string HashItOut(string pass)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        //This will verify that username is not already taken 
        //Will check the dictionary to see if it's there 
        private static bool CheckUserName(string user)
        {
            bool check = true; 
            if (accounts.ContainsKey(user))
            {
                Console.WriteLine("User Name is already taken" +
                    " Please Try Again");
                check = false; 
            }
            return check; 
        }

        //this checks that the username and pass match 
        //-------------finish-----------------------------
        internal static void AuthUser()
        {
            Console.Write("Enter Username:");
            string user = Console.ReadLine();
            if (!accounts.ContainsKey(user))
            {
                Console.WriteLine("Sorry, UserName could not be found" +
                    " Please Try Again \n");
                AuthUser();
            }

            Console.Write("Enter Password:");
            string pass = Console.ReadLine();

            string hashedPass = HashItOut(pass);
            if (accounts.TryGetValue(user, out pass) && hashedPass == pass)

                Console.WriteLine("Account Authenticated \n");
            else
            {
                Console.WriteLine("Sorry Account could not be Authenticated \n");
                PrintUI();
            }
        }


        //this prints out all usernames and hashed out passwords. 
        internal static void PrintUsers()
        {
            //this will print out all usernames and hashed out passwords. 
            foreach (KeyValuePair<string, string> check in accounts)
                Console.WriteLine("UserName:{0} PassWord:{1}", check.Key, check.Value);
        }
    }
}
