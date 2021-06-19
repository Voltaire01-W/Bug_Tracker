using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Animal("bark");
            dog.Speak();

            var cat = new Animal("meow");
            cat.Speak();

            var mouse = new Animal("squeak");
            mouse.Age = 10;
            Console.WriteLine(mouse.Age);
            mouse.Speak();
        }
    }
}
