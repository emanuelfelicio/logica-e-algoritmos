
class Result
{

    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a apple tree
     *  4. INTEGER b orange tree
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int apple = 0;
        int orange = 0;
        for (int i = 0; i < apples.Count; i++)
        {
            if ((a + apples[i]) >= s && (a + apples[i]) <= t)
            {
                apple++;
            }
        }
        for (int i = 0; i < oranges.Count; i++)
        {
            if ((b + oranges[i]) >= s && (b + oranges[i]) <= t)
            {
                orange++;
            }
        }
        Console.WriteLine($"{apple}\n{orange}");
    }

}