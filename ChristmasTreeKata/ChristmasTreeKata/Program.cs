using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTreeKata
{
    public static class Program
    {
        private const char LEAF = '*';
        private const string INDENT = "     ";

        static void Main(string[] args)
        {
            int height = 5;

            if (args.Length > 0)
            {
                int.TryParse(args.FirstOrDefault(), out height);
            }

            Console.WriteLine(GenerateChristmasTree(height));
        }

        public static string GenerateChristmasTree(int height)
        {
            return Enumerable.Range(start: 1, count: height)
                .Select(x => GenerateLevel(x, height, LEAF))
                .Aggregate((l1, l2) => l1 + Environment.NewLine + l2);
        }

        private static string GenerateLevel(int iter, int height, char leaf)
        {
            return INDENT
                + new string(' ', height - iter)
                + new string(leaf, iter * 2 - 1);
        }
    }
}
