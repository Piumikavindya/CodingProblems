namespace Problems;

public class ReversNumber
{

    public static void Run(int num)
    {
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;

            reversed = reversed * 10 + digit;

            num = num / 10;
        }

        Console.WriteLine(reversed);
    }
}