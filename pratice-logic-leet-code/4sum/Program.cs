using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        var set = new HashSet<(int, int, int, int)>();
        var n = nums.Length;

        for (int i = 0; i < n - 3; i++)
        {
            for (int j = i + 1; j < n - 2; j++)
            {
                for (int k = j + 1; k < n - 1; k++)
                {
                    for (int q = k + 1; q < n; q++)
                    {
                        checked
                        {
                            try
                            {
                                if (nums[i] + nums[j] + nums[k] + nums[q] == target)
                                {
                                    if (set.Add((nums[i], nums[j], nums[k], nums[q])))
                                    {
                                        result.Add([nums[i], nums[j], nums[k], nums[q]]);
                                    }

                                }
                            }
                            catch (Exception e)
                            {
                                continue;
                            }

                        }

                    }
                }
            }
        }
        return result.ToArray();
    }

}