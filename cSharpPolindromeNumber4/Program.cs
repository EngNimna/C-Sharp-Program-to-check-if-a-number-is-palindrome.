using System;

namespace cSharpPolindromeNumber4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, rem = 0, rev = 0;
            Console.Write("Enter the number...: ");
            num = int.Parse(Console.ReadLine());
            num2 = num;

            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine(num2);
            
            if (num2 == rev)
            {
                Console.WriteLine(num2 + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine(num2 + " is not a palindrome number.");
            }
        }
    }
}
