using System;

namespace _09._Kamino_Factory {
    class Program {
        static void Main(string[] args) {
            int dnaLength = int.Parse(Console.ReadLine());

            #region BEST

            string[] bestDnaSequence = new string[dnaLength];
            int bestIndexOfMaxOnes = 0;
            int bestLongest = 0;
            int bestOnesSum = 0;
            int bestIndex = 0;

            #endregion

            string command = Console.ReadLine();
            int currIndex = 0;

            while (command != "Clone them!") {
                currIndex++;

                #region CURRENT

                // ReSharper disable once PossibleNullReferenceException
                string[] currDnaSequence = command.Split("!");
                int currIndexOfMaxOnes = 0;
                int currLongest = 0;
                int currSum = 0;

                #endregion

                int currZeros = 0;
                int currOnes = 0;
                int lastNum = -1;

                for (int i = 0; i < currDnaSequence.Length; i++) {
                    if (currDnaSequence[i] == "1") {
                        if (lastNum == 0)
                            currOnes = 0;
                        currOnes++;
                        currSum++;
                        lastNum = 1;
                    } else {
                        if (lastNum == 1)
                            currZeros = 0;
                        currZeros++;
                        lastNum = 0;
                    }

                    if (Math.Max(currZeros, currOnes) > currLongest) {
                        currLongest = Math.Max(currZeros, currOnes);
                        currIndexOfMaxOnes = i - currLongest + 1;
                    }
                }

                // i bet this can be optimized so much more
                if (currLongest > bestLongest) {
                    bestLongest = currLongest;
                    bestIndexOfMaxOnes = currIndexOfMaxOnes;
                    bestOnesSum = currSum;
                    bestIndex = currIndex;
                    bestDnaSequence = currDnaSequence;
                } else if (currLongest == bestLongest) {
                    if (currIndexOfMaxOnes < bestIndexOfMaxOnes) {
                        bestLongest = currLongest;
                        bestIndexOfMaxOnes = currIndexOfMaxOnes;
                        bestOnesSum = currSum;
                        bestIndex = currIndex;
                        bestDnaSequence = currDnaSequence;
                    } else if (currIndexOfMaxOnes == bestIndexOfMaxOnes) {
                        if (currSum > bestOnesSum) {
                            bestLongest = currLongest;
                            bestIndexOfMaxOnes = currIndexOfMaxOnes;
                            bestOnesSum = currSum;
                            bestIndex = currIndex;
                            bestDnaSequence = currDnaSequence;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestOnesSum}.");
            Console.WriteLine(string.Join(" ", bestDnaSequence));
        }
    }
}