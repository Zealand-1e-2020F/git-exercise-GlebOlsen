using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            myClass myclass1 = new myClass("Gleb", "Dnamark", "xxxx", "Blue Lagoon");
            myClass myclass2 = new myClass("Simon", "Dnamark", "xxxx","Blue Lagoon");
            myClass myclass3 = new myClass("John", "Dnamark", "xxxx","Blue Lagoon");
            
            System.Console.WriteLine($"{myclass1}");
            System.Console.WriteLine($"{myclass2}");
            System.Console.WriteLine($"{myclass3}");

        }
    }
}
