public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        int[] v = new int[n + 1];
        int missing = 0, duplicate = 0;

        for (int i = 0; i < n; i++)
        {
            v[nums[i]]++;
        }

        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] == 2)
            {
                duplicate = i;
            }
            if (v[i] == 0)
            {
                missing = i;
            }
        }

        return [duplicate, missing];

    }
}