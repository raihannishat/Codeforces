using System;

namespace TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            long m = long.Parse(line[0]);
            long n = long.Parse(line[1]);
            long a = long.Parse(line[2]);

            long res = ((m + a - 1) / a) * ((n + a - 1) / a);

            Console.WriteLine("{0}", res);   
        }
    }
}
