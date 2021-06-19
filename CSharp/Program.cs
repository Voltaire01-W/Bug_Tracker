using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalNumber = 0;

            int[] myArray = new int[] {
                1, 2, 3, 4, 5
            };

            for (var x = 0; x < myArray.Length; x++) {
                totalNumber = totalNumber + myArray[x];
            }

            Console.WriteLine(totalNumber);

        }
    }
}
