using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPrimes(10001);
            EvenFibonacciSequencer(89);
            LongestCollatzSequence();
            Console.ReadKey();
        }
        static void FindPrimes(int maxPrime)
        {
            int numPrimes = 0;
            int currentNumber = 2;
            while (numPrimes < maxPrime)
            {
                if (IsPrime(currentNumber)) { numPrimes++; }
                currentNumber++;
            }
            Console.WriteLine("last prime was: " + (currentNumber - 1));
        }
        static bool IsPrime(int num)
        {
            bool prime = true;
            for (var i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        static void EvenFibonacciSequencer(int maxValue)
        {
            List<int> fibbyList = new List<int>() { 1, 2 };
            int current = 0;
            int place = 0;
            int output = 0;

            while (fibbyList.Last() < maxValue)
            {
                place = fibbyList[current] + fibbyList[current + 1];

                fibbyList.Add(place);

                current++;

                if (fibbyList[current] % 2 == 0)
                {
                    output += fibbyList[current];
                }
            }
            Console.WriteLine("All together, the even numbers added to " + output);
        }
        static void LongestCollatzSequence()
        {
            long input = int.Parse(Console.ReadLine());

            for (long p = 0; p < input; p++)
            {
                long i = 0;
                while ( i != 1)
                {
                    long seqCounter = 0;
                    string trueSeq = string.Empty;

                    if (i % 2 == 0)
                    {
                        i = i / 2;
                        seqCounter++;
                    }
                    else if (i % 2 != 0)
                    {
                        i = i * 3 + 1;
                        seqCounter++;
                    }
                    else if (i == 1)
                    {
                        seqCounter++;
                        trueSeq = i.ToString();
                        Console.WriteLine("The longest sequence was " + seqCounter + " numbers long for the number " + trueSeq + " for numbers all the way up to " + input + ".");
                        break;
                    }
                }
            }
        }
    }
}
