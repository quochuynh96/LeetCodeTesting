namespace LeetCodeTesting.Problems
{
    public class LengthOfLongestSubstringProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int total = 1;
                for (int j = i; j < s.Length - 1; j++)
                {
                    if (s.Substring(i, j - i + 1).Contains(s[j + 1]))
                    {
                        break;
                    }
                    total++;
                }
                result = total < result ? result : total;
            }
            return result;
        }
    }
}
