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

    public static void Run1()
    {
        string input = "madam";
        int left = 0;
        int right = input.Length - 1;
        bool isPalindrome = true;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        Console.WriteLine(isPalindrome ? $"{input} is a palindrome." : $"{input} is not a palindrome.");
    }


}