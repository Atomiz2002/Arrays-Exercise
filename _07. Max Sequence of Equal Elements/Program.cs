using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements {
    class Program {
        static void Main(string[] args) {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num = 0;
            int len = 0;

            for (int i = 0; i < array.Length; i++) {
                int number = array[i];
                int length = 0;

                for (int j = i; j < array.Length; j++) {
                    if (array[j] == array[i]) {
                        length++;
                    } else {
                        break;
                    }
                }

                if (length > len) {
                    num = number;
                    len = length;
                }
            }

            for (int i = 0; i < len; i++)
                Console.Write(num + " ");
        }
    }
}