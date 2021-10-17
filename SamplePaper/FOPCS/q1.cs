using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.FOPCS
{
    class q1
    {
        // This method is provided to convert char digit to int, e.g: '2' -> 2
        public static int GetIntFromCharDigit(char charDigit)
        {
            return int.Parse(charDigit.ToString());
        }
        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Please type an ISBN number to check, use ? for missing digit.");
           
            string queryISBN = InputISBNForQuery();
            if (string.IsNullOrEmpty(queryISBN))
            {
                Console.WriteLine("You have typed a wrong ISBN number, please only use digits and one '?' ");
               
                Console.ReadLine();
                return;
            }
            int missingIndex = GetMissingIndex(queryISBN);
            // get weighted sum of first twelve digits, except for the missing one.
            int othersWeightedSum = GetOthersWeightedSum(queryISBN);
            int checkDigit = GetIntFromCharDigit(queryISBN[12]);
            int missingDigit = FindMissingDigit(othersWeightedSum, missingIndex,
           checkDigit);
            string message = ("This is the complete ISBN number: \n" +
           queryISBN).Replace("?", missingDigit.ToString());
            Console.WriteLine(message);
            Console.WriteLine("\nType any key to exit.");
            Console.ReadLine();
        }
        // COMPLETE THE FOLLOWING FOUR METHODS
        public static string InputISBNForQuery()
        {
            string inputStr = Console.ReadLine();
            if (inputStr.Length != 13) return null;
            else if (inputStr[12] == '?') return null;
            else
            {
                int countEmpty = 0;
                for(int i = 0; i < inputStr.Length; i++)
                {
                    if (inputStr[i] == '?' || (inputStr[i] >= '0' && inputStr[i] <= '9'))
                    {
                        if (inputStr[i] == '?') countEmpty++;
                    }
                    else return null;
                }
                if (countEmpty != 1) return null;
            }
            return inputStr;
        }
        public static int GetMissingIndex(string queryISBN)
        {
            int index = -1;
            for(int i = 0; i < queryISBN.Length; i++)
            {
                if (queryISBN[i] == '?')
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int GetOthersWeightedSum(string queryISBN)
        {
            int weightSum = 0;
            for(int i = 0; i < queryISBN.Length-1; i++)
            {
                if ((i + 1) % 2 == 0 && queryISBN[i]!='?')
                {
                    weightSum += (GetIntFromCharDigit(queryISBN[i]) * 3);
                }
                else if (queryISBN[i] != '?')
                {
                    weightSum += (GetIntFromCharDigit(queryISBN[i]) * 1);
                }
            }
            return weightSum;
        }
        public static int FindMissingDigit(int othersWeightedSum, int missingIndex, int
        checkDigit)
        {
            int weight = 1;
            if ((missingIndex + 1) % 2 == 0) weight = 3;

            int missingDigit = -1;
            for(int i = 0; i < 10; i++)
            {
                int totalSum = othersWeightedSum + i * weight;
                int remainder = totalSum % 10;
                if ((10 - remainder) % 10 == checkDigit)
                {
                    missingDigit = i;
                    break;
                }
            }
            return missingDigit;
        }
    }
}
