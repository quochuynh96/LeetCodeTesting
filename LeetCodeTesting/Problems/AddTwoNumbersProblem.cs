namespace LeetCodeTesting.Problems
{
    public class AddTwoNumbersProblem
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode? lLoopItem = l1;
            int[] numbers1 = new int[100];
            int[] numbers2 = new int[100];
            int index = 0;

            while (lLoopItem != null)
            {
                numbers1[index] = lLoopItem.val;
                index++;
                lLoopItem = lLoopItem.next;
            }
            int lengthL1 = index;

            index = 0;
            lLoopItem = l2;
            while (lLoopItem != null)
            {
                numbers2[index] = lLoopItem.val;
                index++;
                lLoopItem = lLoopItem.next;
            }

            int lengthL2 = index;

            index = 0;
            int[] numbers3 = new int[100];
            int note = 0;
            for (int i = 0; i < (lengthL1 > lengthL2 ? lengthL1 : lengthL2); i++)
            {
                int sum = (numbers1[i] + numbers2[i] + note);
                numbers3[i] = sum % 10;
                note = sum / 10;
                index++;
            }

            if (note > 0)
            {
                numbers3[index] = note;
                index++;
            }
            int lengthL3 = index;

            index = 0;
            ListNode result = new(numbers3[index]);
            index++;

            lLoopItem = result;

            while (index < lengthL3)
            {
                lLoopItem.next = new ListNode(numbers3[index]);
                index++;
                lLoopItem = lLoopItem.next;
            }
            return result;
        }
    }
}
