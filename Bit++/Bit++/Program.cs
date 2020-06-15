using System;

namespace Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string operation = Console.ReadLine();

                if (Equals(operation, "X++") || Equals(operation, "++X"))
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            Console.WriteLine($"{x}");
        }
    }
}
