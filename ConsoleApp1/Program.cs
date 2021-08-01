using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(MaxWordLengthWithList(new List<string> { "queen", "evelyn", "gbemi", "hafsat", "nazarene" }));
        }

        private static string MaxWordLength(string[] words)
        {
            int maxIndex = 0;
            for (int i = 1; i < words.Length; i++)
            {
                
                    if (words[i].Length > words[maxIndex].Length)
                        maxIndex = i;
                
                




            }
            return words[maxIndex];


        }

        //public static int Sum(int a = 1, int b = 3, int c = 5)
       // {

          //  int Sum = a + b + c;
            //return Sum;

//        }

        private static string MaxWordLengthWithList(List<string> words)
        {
            int maxIndex = 0;
            for (int i = 1; i < words.Count; i++)
            {
                if (words[i].Length > words[maxIndex].Length)
                    maxIndex = i;
            }
            return words[maxIndex];






        }
    }
}
