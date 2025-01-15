using System;

class PrimeNumberSieve
{
    static void GetPrimeNumbers(int limit)
    {
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
            isPrime[i] = true;

        for (int number = 2; number * number <= limit; number++)
        {
            if (isPrime[number])
            {
                for (int multiple = number * number; multiple <= limit; multiple += number)
                {
                    isPrime[multiple] = false;
                }
            }
        }

        Console.WriteLine("Prime numbers up to " + limit + ":");
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter a number to find all prime numbers between 1 and that number: ");
        int limit;
        if (int.TryParse(Console.ReadLine(), out limit) && limit >= 2)
        {
            GetPrimeNumbers(limit);
        }
        else
        {
            Console.WriteLine("Please enter a valid number greater than or equal to 2.");
        }
    }
}