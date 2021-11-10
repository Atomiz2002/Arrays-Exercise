using System;

namespace _05._Top_Integers {
    class Program {
        static void Main(string[] args) {
            string[] array = Console.ReadLine().Split(" ");
            string output = "";

            for (int i = 0; i < array.Length; i++) { // for every element
                bool isBigger = true;

                for (int j = i + 1; j < array.Length; j++) // for every next element
                    if (int.Parse(array[i]) <= int.Parse(array[j])) {
                        isBigger = false;
                        break;
                    }

                if (isBigger)
                    output += array[i] + " ";
            }

            Console.WriteLine(output); // add the final element
        }
    }
}