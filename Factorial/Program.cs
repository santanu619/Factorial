using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int fact = 1;
            int n;
            Console.WriteLine("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is:"+fact);
        }
    }
}
