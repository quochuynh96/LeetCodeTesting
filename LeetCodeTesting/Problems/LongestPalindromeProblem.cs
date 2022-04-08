namespace LeetCodeTesting.Problems
{
    public static class LongestPalindromeProblem
    {
        public static bool isPalindromeString(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static string LongestPalindrome(string s)
        {
            if (s.Length < 2) return s;
            if (s.Length == 2)
            {
                if (isPalindromeString(s))
                {
                    return s;
                }
                return s.Substring(0, 1);
            }
            if (isPalindromeString(s))
            {
                return s;
            }
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                string tempPalindrome = "";
                for (int j = i; j < s.Length; j++)
                {
                    Console.WriteLine(s.Substring(i, j - i + 1));
                    if (isPalindromeString(s.Substring(i, j - i + 1)))
                    {
                        tempPalindrome = s.Substring(i, j - i + 1);
                    }
                }
                result = tempPalindrome.Length > result.Length ? tempPalindrome : result;
            }
            return result;
        }
    }
}
