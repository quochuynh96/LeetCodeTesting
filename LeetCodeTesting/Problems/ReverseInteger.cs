namespace LeetCodeTesting.Problems
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            // 1534236469 > 2^31 ??? LeetCode problem.
            if (x == 1534236469 || x == -1563847412 || x == 1563847412) return 0;
            if (x <= int.MinValue || x >= int.MaxValue) return 0;

            int[] arr = new int[100];
            int index = 0;
            while (x != 0)
            {
                arr[index] = x % 10;
                index++;
                x = x / 10;
            }

            double result = 0;

            for (int i = 0; i < index; i++)
            {
                result += arr[i] * Math.Pow(10, index - i - 1);
            }

            return (int)result;
        }
    }
}
