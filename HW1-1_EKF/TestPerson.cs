using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW1_1_EKF
{
    class TestPerson
    {
        static void Main(string[] args)
        {
            Person joe = new Person();

            joe.Name = "joe";

            Console.WriteLine(joe.Name);

            joe.Address = "3101 Bardstown";

            Console.WriteLine(joe.Address);

            Console.ReadLine();

            Person Lily = new Person();

            //declare variables
            string name, address;

            //get user input
            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("What is your address: ");
            address = Console.ReadLine();

            Lily.Name = name;
            //Lily.Address = address;

            Console.WriteLine("\n" + "Your name is: " + Lily.Name);
            Console.WriteLine("Your address is: " + Lily.Address);

            Console.ReadLine();

        }//end static void Main

    }//end class TestPerson
}
