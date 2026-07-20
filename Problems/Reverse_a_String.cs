using System;
namespace Problems
{
    class Program
    {
        public class Reverse_a_String
        {
            public static void Run()
            {
                string text = "hello";

                char[] arr = text.ToCharArray();

                Array.Reverse(arr);

                Console.WriteLine(arr);
            }

            public static void Run1()
            {

                string input = "Piumi";
                string output = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    output += input[i];
                }
                Console.WriteLine(output);
            }
        }
    }
}