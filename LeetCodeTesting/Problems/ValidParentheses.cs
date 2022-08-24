namespace LeetCodeTesting.Problems
{
    public static class ValidParentheses
    {
        public static bool Validate(string s)
        {
            if (s.Length == 0) return true;
            if (s.Length == 1) return false;

            string s2 = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            
            if (s2.Length == 0 || s2.Contains("()") || s2.Contains("[]") || s2.Contains("{}"))
            {
                return Validate(s2);
            }
            return false;
        }
    }
}

