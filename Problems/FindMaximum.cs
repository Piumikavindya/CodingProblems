namespace Problems;

public class FindMaximum
{
    public static void Run(int[] numbers)
    {

        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine(max);
    }
}