using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            myClass myclass1 = new myClass("Gleb", "Dnamark", "xxxx");
            System.Console.WriteLine($"His name is {myclass1.Name} and he lives in {myclass1.Adresse} and his postal code is {myclass1.PostNB}!");

        }
    }
}
