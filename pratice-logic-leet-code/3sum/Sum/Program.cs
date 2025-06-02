using System.Diagnostics.CodeAnalysis;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = [];
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
            {
                continue;
            }
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum < 0)
                {
                    left++;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    while (nums[left] == nums[left-1] && left<right)
                    {
                        left++;
                    }
                }
            }
        }

        return result;


    }

}