using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Statement that states what the user needs to do.
            Console.WriteLine("Please fill in the necessary details:");

            //The following details need to be entered.
            //Variables have been declared.
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();

            Console.Write("Enter ID number: ");
            double Id = double.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            string Gender = Console.ReadLine();

            Console.Write("Enter Phone number: ");
            double Contact = double.Parse(Console.ReadLine());

            Console.Write("Enter Email: ");
            string Email = Console.ReadLine();

            //Space
            Console.WriteLine();

            //Output on what the user has entered.
            Console.WriteLine("This is the following information you have entered:");
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Id Number: " + Id);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Contact: " + Contact); 
            Console.WriteLine("Email: " + Email);
             Console.WriteLine("Thank you");
            Console.ReadKey();
        }





    }
}
