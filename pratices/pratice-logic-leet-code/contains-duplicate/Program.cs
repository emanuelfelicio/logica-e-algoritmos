public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> result = new(nums.Length);

        foreach (var num in nums)
        {
            if (result.ContainsKey(num))
            {
                return true;
            }
            else
            {
                result[num] = 1;
            }
        }
        return false;

    }
}