using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            List<int> testB = Enumerable.Range(0, 100).ToList();
            List<int> resultOfB = evenFilter(testB);

            #region test
            //Console.WriteLine(findMaxScore(testB));
            // TODO: for test
            //IEnumerable<int> resultOfB = evenFilterYield(testB);

            //foreach (int n in resultOfB)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
        }

        private static decimal findMaxScore(List<decimal> scores)
        {
            decimal maxScore = 0;
            
            foreach (decimal score in scores)
            {
                if (score > maxScore)
                    maxScore = score;
            }

            return maxScore;
        }

        private static List<int> evenFilter(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();

            foreach(int n in numbers)
            {
                if (n == 0)
                    oddNumbers.Add(n);
                else if (n == 1)
                {
                    continue;
                }
                else
                {
                    int t = n / 2;
                    if (t * 2 < n)
                        continue;
                    oddNumbers.Add(t);
                }
            }

            return oddNumbers;
        }

        private static IEnumerable<int> evenFilterYield(List<int> numbers)
        {
            foreach(int n in numbers)
            {
                if (n == 0)
                    yield return n;
                else if (n == 1)
                {
                    continue;
                }
                else
                {
                    int t = n / 2;
                    if (t * 2 < n)
                        continue;
                    yield return n;
                }
            }
        }
    }
}
