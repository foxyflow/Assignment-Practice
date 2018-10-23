using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMethods
{
    class Program

         //public static string UserNameInput(string Prompt)
   // {
      //  Console.WriteLine(Prompt);
       // string username = Console.ReadLine();

     //   return username;
  //  }
    {
        static void Main(string[] args)
        {
           string username = GetUserName("Enter username 8+ characters");

            string password = PasswordMethod("Please enter a password of 8+ characters");
            string password2 = PasswordMethod(password1, password2);// WTF
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
        public static string GetUserName(string promptUserName)
        {
            Console.WriteLine(promptUserName);
            string username = Console.ReadLine();

            while (username.Length <8)
            {
                username = GetUserName("Please enter a longer username");
            }

            return username;
        }
        public static string PasswordMethod(string password1, string password2 ) //I don't understand string passwordconfirmed.. what is this
        {
            Console.WriteLine(password);                                                          //which is also this line
            string password = Console.ReadLine();
            Console.WriteLine(password2);
            string passwordAgain = Console.ReadLine();

            while (password.Length <8)
            {
                password = PasswordMethod("Please enter a longer password");
                
            }
            if (password1 == password2)
            {
                return $"You're passwords {password} meet the citeria";
            }
            
        } 
         
        
    }
}


       


    
            
            
            




































        






















    















        


        




     


    

