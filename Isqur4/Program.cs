using System;
using System.Collections;

namespace Isqur4
{
    public static class Program
    {
        static IEnumerable Squares(this int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                yield return (int)i * i;
            }
        }

        static void Main(string[] args)
        {
            var min = 1;
            foreach (int i in min.Squares(4))
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
