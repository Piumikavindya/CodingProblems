namespace Problems;

public class CountVowels
{
    public static void Run(string input)
    {
        int count = 0;

        foreach (char character in input)
        {
            if ("aeiouAEIOU".Contains(character))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of vowels: {count}");
    }
}