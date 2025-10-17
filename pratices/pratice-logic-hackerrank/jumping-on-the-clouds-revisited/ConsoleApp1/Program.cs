static int jumpingOnClouds(int[] c, int k)
{
    int e = 100;
    int n = c.Length;
    int i = 0;

    do
    {
        i = (i + k) % n;
        if (c[i] == 1)
        {
            e -= 3;
        }
        else
        {
            e--;
        }

    } while (i != 0);
    return e;
}