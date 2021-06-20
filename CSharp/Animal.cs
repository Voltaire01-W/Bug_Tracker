using System;

namespace CSharp {

    public class Animal : IAnimal {
        private string voice;

        private int _age;

        public int Age {
            get {
                return _age;
            }

            set {
                _age = value;
            }
        }

        public Animal(string voice) {
            this.voice = voice;
        }

        public void Speak() {
            Console.WriteLine(voice);
        }

    }

}