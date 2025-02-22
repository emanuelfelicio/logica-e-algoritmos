
int[] GetSneakyNumbers(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    List<int> sneakyNumber = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {

        if (!dict.TryGetValue(nums[i], out int count))
        {
            dict[nums[i]] = 1;
        }
        else
        {
            dict[nums[i]] = count + 1;
        }

        if (dict[nums[i]] == 2)
        {
            sneakyNumber.Add(nums[i]);
        }

    }
    return sneakyNumber.ToArray();
}