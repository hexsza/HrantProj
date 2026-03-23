using System;
using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (true)
            {
                Console.Write("> ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    continue;

                if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine("Additive: {0}", AdditiveHash(input));
                Console.WriteLine("Folding : {0}", FoldingHash(input));
            }
        }

        private static int AdditiveHash(string input)
        {
            int currentHash = 0;

            foreach (char c in input)
            {
                unchecked
                {
                    currentHash += c;
                }
            }

            return currentHash;
        }

        private static int FoldingHash(string input)
        {
            int hashValue = 0;
            int startIndex = 0;
            int currentFourBytes;

            do
            {
                currentFourBytes = GetNextBytes(startIndex, input);

                unchecked
                {
                    hashValue += currentFourBytes;
                }

                startIndex += 4;

            } while (currentFourBytes != 0);

            return hashValue;
        }

        private static int GetNextBytes(int startIndex, string str)
        {
            int currentFourBytes = 0;

            currentFourBytes += GetByte(str, startIndex);
            currentFourBytes += GetByte(str, startIndex + 1) << 8;
            currentFourBytes += GetByte(str, startIndex + 2) << 16;
            currentFourBytes += GetByte(str, startIndex + 3) << 24;

            return currentFourBytes;
        }

        private static int GetByte(string str, int index)
        {
            if (index < str.Length)
            {
                return str[index];
            }

            return 0;
        }
    }
}