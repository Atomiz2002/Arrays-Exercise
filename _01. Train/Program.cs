using System;

namespace _01._Train {
    class Program {
        static void Main(string[] args) {
            int wagons = Convert.ToInt32(Console.ReadLine());
            int[] passengers = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++) {
                passengers[i] = Convert.ToInt32(Console.ReadLine());
                sum += passengers[i];
            }

            Console.WriteLine(String.Join(' ', passengers));
            Console.WriteLine(sum);
        }
    }
}