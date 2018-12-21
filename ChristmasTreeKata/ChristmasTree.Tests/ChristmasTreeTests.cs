using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree.Tests
{
    [TestFixture]
    public class ChristmasTreeTests
    {
        private const string INDENT = "     ";

        [Test]
        public void should_generate_tree_1()
        {
            int input = 1;
            string expected = INDENT + "*";
            string output = ChristmasTreeKata.Program.GenerateChristmasTree(input);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void should_generate_tree_2()
        {
            int input = 2;

            var expected = new List<string>
            {
                INDENT+" *",
                INDENT+"***"
            };

            string output = ChristmasTreeKata.Program.GenerateChristmasTree(input);
            Assert.AreEqual(string.Join(Environment.NewLine, expected), output);
        }

        [Test]
        public void should_generate_tree_6()
        {
            int input = 6;

            var expected = new List<string>
            {
                INDENT+"     *",
                INDENT+"    ***",
                INDENT+"   *****",
                INDENT+"  *******",
                INDENT+" *********",
                INDENT+"***********"
            };

            string output = ChristmasTreeKata.Program.GenerateChristmasTree(input);
            Assert.AreEqual(string.Join(Environment.NewLine, expected), output);
        }
    }
}
