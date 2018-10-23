using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeptrying
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initilising the strings
            string username = UserNameInput("Enter username with 8+ characters");
            string password = "";
            string confirmPassword = "";

            

            while (username.Length < 8)
            {
                username = UserNameInput("Please enter a longer username.");
            }

            Console.WriteLine("Successful username");


            //string password1 =
            while (password.Length < 8)
            {
                password = Getpassword();
            }

            Console.WriteLine("Please confirm password");
            confirmPassword = Getpassword();

            while (password != confirmPassword)
            {
                Console.WriteLine("Passwords do not match, please confirm again");
                confirmPassword = Getpassword();
            }
            HereToHere();
            
        }

        private static void HereToHere()
        {
            Console.WriteLine("Congradulations, you're all set up");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }

        public static string Getpassword()
        {
            Console.WriteLine("please enter password");
            string password = Console.ReadLine();
           
            return password;
        }

        public static string UserNameInput(string Prompt)
        {
            Console.WriteLine(Prompt);
            string username = Console.ReadLine();
       
            return username;
        }
       

        















    }
}
