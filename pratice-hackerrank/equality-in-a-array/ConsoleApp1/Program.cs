using System.Runtime.InteropServices.Marshalling;
Console.WriteLine(Result.equalizeArray([3, 3, 2, 1, 3]));
class Result
{

    /*
     * Complete the 'equalizeArray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int equalizeArray(List<int> arr)
    {
        arr.Sort();

        int count = 0;
        int finalCount = 0;
        int value = arr[0];
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] == value)
            {
                count++;
            }
            else
            {
                value = arr[i];
                count = 1;
            }
            if (count > finalCount)
            {
                finalCount = count;
            }
        }
        return arr.Count - finalCount;
    }
}