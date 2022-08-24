using LeetCodeTesting.Problems;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LeetCodeTestingUnitTest
{
    [TestFixture]
    public class ValidParenthesesTest
    {
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("{[]}", true)]
        public async Task ValidPauerenthesesTesting(string input, bool output)
        {
            Assert.AreEqual(ValidParentheses.Validate(input), output);
        }
    }
}
