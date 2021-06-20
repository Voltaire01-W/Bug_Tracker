using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("Enter your name: ");
                var name = Console.ReadLine();

                if (name == "") {
                    throw new Exception("You really screwed this one up. lol");
                }

                Console.WriteLine("Hello " + name);
            }
        }
    }
}
