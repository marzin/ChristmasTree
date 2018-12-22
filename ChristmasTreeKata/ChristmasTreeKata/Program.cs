using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTreeKata
{
    public static class Program
    {
        private const char STAR = 'X';
        private const char LEAF = '*';
        private const string INDENT = "     ";

        static void Main(string[] args)
        {
            int height = 5;

            if (args.Length > 0)
            {
                int.TryParse(args.FirstOrDefault(), out height);
            }

            Console.WriteLine("Functionnal Method");
            Console.WriteLine(GenerateChristmasTree(height, star: true));

            Console.WriteLine("Recursive Method");
            Console.WriteLine(GenerateTreeRec());
        }

        public static string GenerateChristmasTree(int height, bool star = false)
        {
            return Enumerable.Range(start: star ? 0 : 1, count: star ? height + 1 : height)
                .Select(x => GenerateLevel(x, height, LEAF, star, STAR, INDENT))
                .Aggregate((x, y) => x + Environment.NewLine + y);
        }

        private static string GenerateLevel(int iter, int height, char leaf, bool displayStar, char star, string indent)
        {
            if (iter == height || iter == 0)
                return indent
                    + new string(' ', Math.Max(0, height - 2))
                    + (iter == 0 ? star : leaf);

            return indent
                + new string(' ', height - iter - 1)
                + new string(leaf, iter * 2 - 1);
        }


        private static string GenerateTreeRec(int iter = 0, int height = 5, char leaf = '*', bool displayStar = true, char star = 'X', string indent = "     ", string Acc = "")
        {
            string level = "";
            if (iter == height)
                return Acc
                        + indent
                        + new string(' ', Math.Max(0, height - 2))
                        + leaf;

            if (iter == 0)
            {
                level = indent
                    + new string(' ', Math.Max(0, height - 2))
                    + star
                    + Environment.NewLine;
            }
            else
            {
                level = indent
                    + new string(' ', height - iter - 1)
                    + new string(leaf, iter * 2 - 1)
                    + Environment.NewLine;
            }

            return GenerateTreeRec(iter + 1, height, leaf, displayStar, star, indent, Acc + level);
        }
    }
}
