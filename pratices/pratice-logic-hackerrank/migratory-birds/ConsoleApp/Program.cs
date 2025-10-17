class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> dict = new();
        int resultId = 0;
        int maxValue = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (!dict.TryGetValue(arr[i], out int value))
            {
                value = 1;
                dict.Add(arr[i], value);
            }
            else
            {
                dict[arr[i]] = value + 1;

            }
            if (value > maxValue)
            {
                maxValue = value;
                resultId = arr[i];
            }
            if (value == maxValue && arr[i] < resultId)
            {
                resultId = arr[i];
            }

        }
        return resultId;
    
    }

}