namespace LeetCodeTesting.Problems
{
    public static class ZigzagConversionProblem
    {
        public static string Convert(string s, int numRows)
        {
            int[] arr = Enumerable.Range(0, s.Length).ToArray();
            int x = 0;
            int y = 0;
            int index = 0;
            char[,] zigzagMaxtrix = new char[s.Length, numRows + 1];
            if (numRows < 2) return s;
            while (index < s.Length)
            {
                if (x % (numRows - 1) == 0)
                {
                    zigzagMaxtrix[x, y] = s[index];
                    index++;
                }
                else
                {
                    if ((x + y) % (numRows - 1) == 0)
                    {
                        zigzagMaxtrix[x, y] = s[index];
                        index++;
                    }
                }

                y++;
                if (y == numRows)
                {
                    x++;
                    y = 0;
                }
            }


            char[] result = new char[s.Length];
            int k = 0;
            for (int j = 0; j <= numRows; j++)
            {
                for (int i = 0; i <= x; i++)
                {
                    // Console.WriteLine("[" + i + "," + j + "]= " + zigzagMaxtrix[i, j]);
                    if (zigzagMaxtrix[i, j] != char.MinValue)
                    {
                        result[k] = zigzagMaxtrix[i, j];
                        k++;
                    }
                }
            }

            return new string(result);
        }
    }
}
