using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            double ID;
            string Surname;
            string FirtName;
            string Gender;
            string DOB;
            string Province;

            //Enter values
            Console.Write("Enter your ID: ");
            ID =Convert.ToDouble( Console.ReadLine());
            Console.Write("Enter you Surname: ");
            Surname = Console.ReadLine();
            Console.Write("Enter your FirstName: ");
            FirtName = Console.ReadLine();
            Console.Write("Enter you Gender: ");
            Gender = Console.ReadLine();
            Console.Write("Enter you Date of Birth: ");
            DOB = Console.ReadLine();
            Console.Write("Enter you Province: ");
            Province = Console.ReadLine();

            //Space
            Console.WriteLine();

            //Output 
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("First Name: "+ FirtName);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("Date of Birth: "+ DOB);
            Console.WriteLine("Province: "+ Province);

            Console.ReadKey();
        }

    }
}
