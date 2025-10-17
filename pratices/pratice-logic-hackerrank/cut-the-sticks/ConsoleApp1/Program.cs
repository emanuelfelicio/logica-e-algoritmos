class Result
{

    /*
     * Complete the 'cutTheSticks' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> cutTheSticks(List<int> arr)
    {
        List<int> result = [];
        arr.Sort();

        while (arr.Count > 0)
        {

            result.Add(arr.Count);

            int leastNumber = arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                int currentStick = arr[i] - leastNumber;

                if (currentStick > 0)
                {
                    arr[i] = currentStick;
                }
                else
                {
                    arr.RemoveAt(i);
                    i--;
                }
            }
        }
        return result;
    }

}