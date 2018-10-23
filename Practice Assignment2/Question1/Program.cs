using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            string password2 = Console.ReadLine();

            LearningReturns(password, password2);

            Console.WriteLine("End of program");
            Console.ReadLine();
        }
        private static string LearningReturns(string password, string password2)
        {
            Console.WriteLine("Enter a password");
            

            while (password.Length <5)
            {
                password = password2;
            }

            Console.WriteLine("Password Confimed");

            return password;

          


            


        }

        private static void IsStringGreaterthan2char(string omething, string password2)
        {

        }
    }
}

