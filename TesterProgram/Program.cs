using Classes_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Student Class Examples ******");
            Student scott = new Student();
            scott.FirstName = "Scott";
            scott.LastName = "Summers";
            scott.ID = "Cyclops";
            scott.GPA = 3.45f;
            Student jean = new Student("Jean", "Grey", "Phoenix", 4.9f);
            Console.WriteLine("Using Default Constructor:");
            Console.WriteLine(scott.ToString());
            Console.WriteLine();
            Console.WriteLine("Using a Fully-Qualified Constructor:");
            Console.WriteLine(jean.ToString());
            Console.WriteLine();

            Console.WriteLine("****** Vehicle Class Examples ******");
            Vehicle delorean = new Vehicle();
            delorean.Make = "DeLorean";
            delorean.Model = "DMC-12";
            delorean.Year = 1983;
            delorean.Weight = 2712f;
            Vehicle kitt = new Vehicle("Pontiac", "Firebird", 1982, 3175f);
            Console.WriteLine("Using Default Constructor:");
            Console.WriteLine(delorean.ToString());
            Console.WriteLine();
            Console.WriteLine("Using a Fully-Qualified Constructor:");
            Console.WriteLine(kitt.ToString());
            Console.WriteLine();

            Console.WriteLine("****** Login Class Examples ******");
            Login secret = new Login();
            secret.UserName = "youllneverguess";
            secret.Password = "123456";
            Login smart = new Login("smarter", "J3llyF!sh");
            Console.WriteLine("Using Default Constructor:");
            Console.WriteLine(secret.ToString());
            Console.WriteLine();
            Console.WriteLine("Using a Fully-Qualified Constructor:");
            Console.WriteLine(smart.ToString());
            Console.WriteLine();

            Console.WriteLine("****** Contact Info Class Examples ******");
            ContactInfo nancy = new ContactInfo();
            nancy.StreetAddress = "1428 Elm Street";
            nancy.City = "Springwood";
            nancy.State = "OH";
            nancy.Zip = "66600";
            nancy.Phone = "555-NVR-SLEEP";
            nancy.Email = "nancy@nightmare.com";
            ContactInfo sidney = new ContactInfo("1234 Main Street", "Woodsboro", "CA", "98102", "555-TRS-TNONE", "sidney@ghostface.com");
            Console.WriteLine("Using Default Constructor:");
            Console.WriteLine(nancy.ToString());
            Console.WriteLine();
            Console.WriteLine("Using a Fully-Qualified Constructor:");
            Console.WriteLine(sidney.ToString());
            Console.WriteLine();
        }
    }
}
