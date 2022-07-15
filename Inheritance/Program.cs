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
            pigeons.NumberOfLegs = 4;
            pigeons.CanFly = true;
            pigeons.HasTail = true;
            pigeons.Size = "small";
            pigeons.WingSpan = 26.4;
            pigeons.TypeOfBird = "pigeon";
            pigeons.FavoriteFood = "everything";
            Console.WriteLine($"A {pigeons.TypeOfBird} is {pigeons.Size} with {pigeons.NumberOfLegs}. It has a wingspan of {pigeons.WingSpan} inches and love to eat {pigeons.FavoriteFood}.");
            Console.WriteLine($"Can a pigeons fly? {pigeons.CanFly}");
            Console.WriteLine($"Does a pigeons have a tail? {pigeons.HasTail}");
            Console.WriteLine("-------------------------------");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile turtle = new Reptile() { NumberOfLegs = 4, HasShell = true, HasTail = true, Weight = 110, CanFly = false, Size = "medium", Color = "Dark Brown", NumberOfTeeth = 0};
            Console.WriteLine($"A Turtle has {turtle.NumberOfLegs} legs, has {turtle.NumberOfTeeth} teeth, has a color of {turtle.Color}, is usally {turtle.Size} size and weight around {turtle.Weight} pounds.");
            Console.WriteLine($"Does a turle have a shell? {turtle.HasShell}");
            Console.WriteLine($"Does a turle have a tail? {turtle.HasTail}");
            Console.WriteLine($"Can a turtle fly? {turtle.CanFly}");
        }
    }
}
