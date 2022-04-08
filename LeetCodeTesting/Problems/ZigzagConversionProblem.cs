namespace LeetCodeTesting.Problems
{
    public static class ZigzagConversionProblem
    {
        public static string Convert(string s, int numRows)
        {
            int[] arr = Enumerable.Range(0, s.Length).ToArray();
            bool isDown = true;

            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (isDown)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

                else
                {
                    if (arr[i] < arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }

                isDown = !isDown;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            return s;
        }
    }
}
