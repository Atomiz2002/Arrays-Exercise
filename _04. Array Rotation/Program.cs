using System;

namespace _04._Array_Rotation {
    class Program {
        static void Main(string[] args) {
            // goal: no LINQ

            string[] array = Console.ReadLine().Split(" ");
            int rotations = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rotations % array.Length; i++) { // cuts out the unnecessary rotations
                string firstElement = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                    array[j] = array[j + 1];

                array[array.Length - 1] = firstElement;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}