using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird Toucan = new Bird();
            Toucan.HasFourLegs = false;
            Toucan.CanFly = true;
            Toucan.LaysEggs = true;
            Toucan.HasFeathers = true;
            Toucan.IsColorful = true;
            Toucan.Sound = "CAW CAWWW";
            Console.WriteLine("What sound does a toucan make?");
            Console.WriteLine($"The toucan makes the sound {Toucan.Sound}!");

            Console.WriteLine("Which of the follwing are true?");
            }
        }
    }
}
