using System;

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
            Bird pigeons = new Bird();
            pigeons.CanFly = true;
            pigeons.WingSpan = 26.4;
            pigeons.Size = "small";
            pigeons.FavoriteFood = "everything";
            Console.WriteLine($"A {pigeons} is {pigeons.Size}. It has a wingspan of {pigeons.WingSpan} inches and love to eat {pigeons.FavoriteFood}.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile turtle = new Reptile() { NumberOfLegs = 4, HasShell = true, HasTail = true, Weight = 110};
            Console.WriteLine($"{turtle} has {turtle.NumberOfLegs} legs and weight around {turtle.Weight} pounds");
            Console.WriteLine($"Does a turle have a shell? {turtle.HasShell}");
            Console.WriteLine($"Does a turle have a tail? {turtle.HasTail}");
        }
    }
}
