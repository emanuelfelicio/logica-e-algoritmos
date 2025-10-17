using System.Globalization;

Solution.RemoveElement([2, 2, 2, 2], 2);

public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {


        Array.Sort(nums);
        int indexVal = Array.IndexOf(nums, val);

        int countVal = 0;
        if (indexVal >= 0)
        {
            for (int i = indexVal; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    countVal++;
                }
                else
                {
                    break;
                }
            }


            // swapando com ultimos elementos
            int j = 0;
            for (int i = indexVal; i < indexVal + countVal; i++)
            {
                (nums[nums.Length - 1 - j], nums[i]) = (nums[i], nums[nums.Length - 1 - j]);
                j++;
            }


        }

        int k = nums.Length - countVal;
        return k;


    }
}


