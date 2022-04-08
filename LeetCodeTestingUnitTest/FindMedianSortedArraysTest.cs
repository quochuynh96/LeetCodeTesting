using LeetCodeTesting.Problems;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeetCodeTestingUnitTest
{

    [TestFixture]
    public class FindMedianSortedArraysTest
    {
        public partial class InputData
        {
            public int[] a { get; set; }
            public int[] b { get; set; }
            public double resutl { get; set; }
            public InputData(int[] x, int[] y, double z)
            {
                a = x; b = y; resutl = z;
            }
        }

        static IEnumerable<InputData> InitData()
        {
            yield return new InputData(new int[2] { 1, 3 }, new int[1] { 2 }, 2);
            yield return new InputData(new int[2] { 0, 0 }, new int[1] { 0 }, 0);
        }

        [TestCaseSource(nameof(InitData))]
        public async Task FindMedianSortedArraysTesting(InputData input)
        {
            Assert.AreEqual(FindMedianSortedArraysProblem.FindMedianSortedArrays(input.a, input.b), input.resutl);
        }

    }
}