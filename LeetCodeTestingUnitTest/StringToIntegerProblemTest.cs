using LeetCodeTesting.Problems;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LeetCodeTestingUnitTest
{
    [TestFixture]
    public class StringToIntegerProblemTest
    {

        [TestCase("42", 42)]
        [TestCase("-123", -123)]
        [TestCase("     -42", -42)]
        [TestCase("4193 with words", 4193)]
        [TestCase("-91283472332", -2147483648)]
        [TestCase("", 0)]
        [TestCase("  ", 0)]
        [TestCase("+1", 1)]
        [TestCase("20000000000000000000", 2147483647)]
        [TestCase("  0000000000012345678", 12345678)]
        [TestCase("+-12", 0)]
        [TestCase("+", 0)]
        [TestCase("00000-42a1234", 0)]
        [TestCase(" ++1", 0)]
        public async Task StringToIntegerProblemTesting(string input, int result)
        {
            Assert.AreEqual(result, StringToIntegerProblem.MyAtoi(input));
        }
    }
}
