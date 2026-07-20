using System;
using System.Text;
namespace Problems
{
    class Program
    {
        public class Reverse_a_String
        {
            public static void Run()
            {
                string text = "hello";

                char[] arr = text.ToCharArray();  //strings are immutable. Strings cannot be modified. Arrays can.

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

            public static void Run2()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Hello");
                StringBuilder reversed = new StringBuilder();

                for (int i = sb.Length - 1; i >= 0; i--)
                {
                    reversed.Append(sb[i]);
                }
                Console.WriteLine(reversed.ToString());
            }

        }
    }
}