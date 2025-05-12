
Result.jumpingOnClouds([0, 0, 1, 0, 0, 1, 0]);
class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int numberOfJumps = 0;
        int index = 0;


        while (index < c.Count - 1)
        {
            if (index + 2 < c.Count && c[index + 2] == 0)
            {
                index += 2;
            }
            else
            {
                index++;
            }
            numberOfJumps++;

        }

        return numberOfJumps;



    }
}
