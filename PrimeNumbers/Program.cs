/*5. Write a program which will print all prime numbers between 1 and the number given by the user.
In your solution implement the sieve of Eratosthenes.*/

using System;
namespace PrimeNumbers
{
    class Mohamed
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insert your limit number: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine($"The prime numbers between 1 and {limit} are: ");
            bool[] numbers = new bool[limit + 1];
            for (int i = 2; i < limit; i++)
            {
                if (!numbers[i])
                {
                    Console.Write("{0} ", i);
                    for (int j = i * 2; j < limit; j += i)
                    {
                        numbers[j] = true;
                    }   
                }
            }
            Console.ReadLine();
        }
    }
}