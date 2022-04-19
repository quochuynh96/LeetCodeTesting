namespace LeetCodeTesting.Problems
{
    public static class StringToIntegerProblem
    {
        public static int MyAtoi(string s)
        {
            if (s == null || s == "" || s.Trim() == "") return 0;
            s = s.Trim();

            if ((s.Length > 1 && s[0] == '-' && s[1] == '+') || (s.Length > 1 && s[0] == '+' && s[1] == '-') || (s.Length > 1 && s[0] == '+' && s[1] == '+') || (s.Length > 1 && s[0] == '-' && s[1] == '-')) return 0;

            if (s[0] <= '9' && s[0] >= '0')
            {
                int nonZero = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] > '9' || s[i] < '0')
                    {
                        break;
                    }
                    else
                    {
                        if (s[i] <= '9' && s[i] > '0')
                        {
                            nonZero++;
                        }
                    }
                }
                Console.WriteLine(nonZero);
                if (nonZero < 1) return 0;
            }


            bool isNegative = s[0] == '-';

            while (s.Length > 1 && (s[0] == '-' || s[0] == '+' || s[0] == '0'))
            {
                s = s.Substring(1);
            }
            if (s.Length == 0) return 0;

            int[] arr = new int[s.Length];
            int index = 0;
            long result = 0;
            while (index < s.Length && s[index] <= '9' && s[index] >= '0')
            {
                arr[index] = s[index];
                index++;
            }

            if (index > 10) return isNegative ? int.MinValue : int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                result += (arr[i] - 48) * (long)Math.Pow(10, index - i - 1);
                if (result > int.MaxValue)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }
            }

            result *= (isNegative ? -1 : 1);
            return (int)result;
        }
    }
}
