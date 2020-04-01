using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            myClass myclass1 = new myClass("Gleb", "Dnamark", "xxxx");
            myClass myclass2 = new myClass("Simon", "Dnamark", "xxxx");
            myClass myclass3 = new myClass("John", "Dnamark", "xxxx");
            
            System.Console.WriteLine($"{myclass1}");
            System.Console.WriteLine($"{myclass2}");
            System.Console.WriteLine($"{myclass3}");

        }
    }
}
