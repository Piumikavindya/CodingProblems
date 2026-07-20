using System.Text;

namespace Problems;

public class Palindrome
{
    public static void Run()
    {
        string input = "madam";
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        if (input == reversed.ToString())
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }


}