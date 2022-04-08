using LeetCodeTesting.Problems;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LeetCodeTestingUnitTest
{
    [TestFixture]
    public class ZigzagConversionProblemTest
    {
        [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [TestCase("A", 1, "A")]
        public async Task ZigzagConversionProblemTesting(string input, int numRows, string output)
        {
            Assert.AreEqual(ZigzagConversionProblem.Convert(input, numRows), output);
        }
    }
}
