using System;

namespace WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string word = Console.ReadLine();

                if (word.Length <= 10)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    Console.WriteLine($"{word[0]}{word.Length - 2}{word[word.Length - 1]}");
                }
            }
        }
    }
}
