namespace Problems;

public class ArmstrongNumber
{
    public static void Run(int num)
    {
        int sum = 0;
        int originalNum = num;
        while (num != 0)
        {
            int digit = num % 10;
            sum = sum + digit * digit * digit;
            num = num / 10;
        }

        if (sum == originalNum)
        {
            Console.WriteLine($"{originalNum} is Armstrong Number");
        }
        else
        {
            Console.WriteLine($"{originalNum} is not ArmstrongNumber");
        }
    }
}