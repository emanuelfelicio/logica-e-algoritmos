

int NumIdenticalPairs(int[] nums)
{
    Dictionary<int, int> numsDictionary = new(nums.Length);
    int count = 0;
    foreach (var num in nums)
    {
        if (numsDictionary.ContainsKey(num))
        {
            count += numsDictionary[num];
            numsDictionary[num]++;
        }
        else
        {
            numsDictionary[num] = 1;
        }
    }
    return count;

}
