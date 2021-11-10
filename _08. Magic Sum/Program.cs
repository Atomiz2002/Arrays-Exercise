﻿using System;
using System.Linq;

namespace _08._Magic_Sum {
    class Program {
        static void Main(string[] args) {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum = Convert.ToInt32(Console.ReadLine());
            string output = "";

            for (int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] + array[j] == sum) {
                        output += array[i] + " " + array[j] + "\n";
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}