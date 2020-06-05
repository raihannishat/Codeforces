using System;

namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());

            if (Weight(w))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Weight(int weight)
        {
            if (weight % 2 == 0 && weight > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
