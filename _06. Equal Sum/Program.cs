using System;
using System.Linq;

namespace _06._Equal_Sum {
    class Program {
        static void Main(string[] args) {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string output = "no";

            for (int i = 0; i < array.Length; i++) {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                    leftSum += array[j];

                for (int j = i + 1; j < array.Length; j++)
                    rightSum += array[j];

                if (leftSum == rightSum) {
                    output = i + "";
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}