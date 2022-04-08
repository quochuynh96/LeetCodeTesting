using LeetCodeTesting.Problems;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeetCodeTestingUnitTest
{
    [TestFixture]
    public class LongestPalindromeProblemTest
    {
        static IEnumerable<string[]> InitData()
        {
            yield return new string[2] { "babad", "bab" };
            yield return new string[2] { "cbbd", "bb" };
            yield return new string[2] { "a", "a" };
            yield return new string[2] { "bb", "bb" };
            yield return new string[2] { "ac", "a" };
            yield return new string[2] { "ccc", "ccc" };
            yield return new string[2] { "abb", "bb" };
        }

        [TestCaseSource(nameof(InitData))]
        public async Task FindMedianSortedArraysTesting(string[] input)
        {
            Assert.AreEqual(LongestPalindromeProblem.LongestPalindrome(input[0]), input[1]);
        }
    }
}
