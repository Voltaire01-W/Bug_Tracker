using System;

namespace CSharp {

    public class Dog : Animal {
        public Dog(string voice) : base(voice) {
            Console.WriteLine("Inheritance");
        }
    }

}