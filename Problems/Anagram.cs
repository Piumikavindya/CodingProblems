using System;
namespace Problems;

public class Anagram()
{

    public static void Run()
    {
        string first = "listen";
        string second = "silent";

        if (first.Length != second.Length)
        {
            Console.WriteLine("Not a Anagram");
        }

        char[] firstArray = first.ToCharArray();
        char[] secondArray = second.ToCharArray();

        Array.Sort(firstArray);
        Array.Sort(secondArray);

        bool isAnagram = true;

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isAnagram = false;
                break;
            }
        }

        Console.WriteLine(isAnagram ? $"{first} and {second} are anagrams." : $"{first} and {second} are not anagrams.");
    }

    public static void Run1()
    {
        string first = "listen";
        string second = "silent";

        if (first.Length != second.Length)
        {
            Console.WriteLine("Not a Anagram");
        }

        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in first)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }
        foreach (char c in second)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]--;
            }
            else
            {
                Console.WriteLine("Not Anagram");
                return;
            }
        }


        foreach (var item in frequency)
        {
            if (item.Value != 0)
            {
                Console.WriteLine("Not Anagram");
                return;
            }
        }


        Console.WriteLine("Anagram");
    }
}