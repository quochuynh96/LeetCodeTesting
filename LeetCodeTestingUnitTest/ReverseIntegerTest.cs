using LeetCodeTesting.Problems;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LeetCodeTestingUnitTest
{
    [TestFixture]
    public class ReverseIntegerTest
    {

        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        [TestCase(-2147483648, 0)]
        [TestCase(-1563847412, 0)]
        [TestCase(-2147483412, -2143847412)]
        [TestCase(1563847412, 0)]
        public async Task ReverseIntegerProblemTesting(int input, int result)
        {
            Assert.AreEqual(result, ReverseInteger.Reverse(input));
        }
    }
}
