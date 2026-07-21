namespace Problems;

public class Fibonacci
{
    public static void Run(int n)
    {
        int first = 0;
        int second = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
}