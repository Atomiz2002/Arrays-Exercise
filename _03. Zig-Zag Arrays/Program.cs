using System;

namespace _03._Zig_Zag_Arrays {
    class Program {
        static void Main(string[] args) {
            // TODO simplify

            int n = Convert.ToInt32(Console.ReadLine());
            string[] output1 = new string[n];
            string[] output2 = new string[n];

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(" ");

                if (i % 2 == 0) {
                    output1[i] = input[0];
                    output2[i] = input[1];
                } else {
                    output1[i] = input[1];
                    output2[i] = input[0];
                }
            }

            for (int i = 0; i < output1.Length; i++)
                Console.Write(output1[i] + " ");

            Console.WriteLine();

            for (int i = 0; i < output2.Length; i++)
                Console.Write(output2[i] + " ");
        }
    }
}