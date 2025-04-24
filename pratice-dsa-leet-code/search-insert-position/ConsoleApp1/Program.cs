public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int index = Array.BinarySearch(nums, target);

        if (index < 0)
        {
            // obtém o index do proximo item que é maior que target;
            index = ~index;

            if (index < 0)
            {
                index = nums.Length - 1;
            }
        }

        return index;

    }
}