namespace LeetCodeTesting.Problems
{
    public static class FindMedianSortedArraysProblem
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = new int[5000];
            int length = nums1.Length + nums2.Length;

            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < length; i++)
            {
                if (index1 >= nums1.Length)
                {
                    nums3[i] = nums2[index2];
                    index2++;
                }
                else if (index2 >= nums2.Length)
                {
                    nums3[i] = nums1[index1];
                    index1++;
                }
                else
                {
                    if (nums1[index1] < nums2[index2])
                    {
                        nums3[i] = nums1[index1];
                        index1++;
                    }
                    else
                    {
                        nums3[i] = nums2[index2];
                        index2++;
                    }
                }
            }
            if (length % 2 == 0)
            {
                return (double)(nums3[length / 2 - 1] + nums3[length / 2]) / 2;
            }
            else
            {
                return nums3[length / 2];
            }
        }
    }
}
