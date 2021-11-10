using System;
using System.Linq;

namespace _02._Common_Elements {
    class Program {
        static void Main(string[] args) {
            string[] input1 = Console.ReadLine().Split(" ");
            string[] input2 = Console.ReadLine().Split(" ");
            string output = "";

            for (int i = 0; i < input1.Length; i++)
                if (input2.Contains(input1[i]))
                    output += input1[i] + " ";

            Console.WriteLine(output);
        }
    }
}