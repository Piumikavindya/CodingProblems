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

        if (isAnagram)
        {
            Console.WriteLine($"{first} and {second} are anagrams.");
        }
        else
        {
            Console.WriteLine($"{first} and {second} are not anagrams.");
        }
    }
}