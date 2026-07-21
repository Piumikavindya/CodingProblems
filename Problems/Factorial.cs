namespace Problems;

public class Factorial
{
    public static void Run(int num)
    {
        int result = 1;

        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        Console.WriteLine($"Factorial of {num} is {result}");
    }
}