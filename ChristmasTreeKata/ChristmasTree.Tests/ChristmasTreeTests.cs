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
        [Test]
        public void should_generate_tree_1()
        {
            int input = 1;
            string expected = "*";
            string output = ChristmasTreeKata.Program.GenerateChristmasTree(input);
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void should_generate_tree_2()
        {
            int input = 2;

            string expected = string.Empty;
            expected += " *";
            expected += "***";

            string output = ChristmasTreeKata.Program.GenerateChristmasTree(input);
            Assert.AreEqual(expected, output);
        }
    }
}
