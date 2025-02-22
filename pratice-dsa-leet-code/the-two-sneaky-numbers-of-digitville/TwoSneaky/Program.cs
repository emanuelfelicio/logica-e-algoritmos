


int[] GetSneakyNumbers(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    List<int> sneakyNumber = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (dict.ContainsKey(nums[i]))
        {
            dict[nums[i]]++;
        }
        else
        {
            dict[nums[i]] = 1;
        }

        if (dict[nums[i]] > 1 && !sneakyNumber.Contains(nums[i]))
        {
            sneakyNumber.Add(nums[i]);
        }

    }
    return sneakyNumber.ToArray();
}