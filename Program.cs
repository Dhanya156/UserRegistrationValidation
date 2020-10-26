using System;

namespace UserRegistrationValidation
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///Creating object for class pattern
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the Email to validate");
            ///Reading input from user
            string email = Console.ReadLine();
            //Calling a method to validate
            Console.WriteLine(pattern.ValidateEmail(email));
        }
    }
}
