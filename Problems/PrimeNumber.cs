using Problems;

public class PrimeNumber
{

    public static void Run(int num)
    {
        if (num <= 1)
        {
            Console.WriteLine($"{num} is not a prime number.");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i < num; i++)
        {

            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? $"{num} is a prime number." : $"{num} is not a prime number.");

    }
}