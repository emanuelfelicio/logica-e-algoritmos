using System.Text;


Result.beautifulDays(20, 23, 6);
class Result
{

    /*
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    public static int beautifulDays(int i, int j, int k)
    {
        int count = 0;
        while (i <= j)
        {
            StringBuilder number = new(i.ToString());
            int n = number.Length;
            for (int a = 0; a < n / 2; a++)
            {
                // invertendo numero
                (number[n - 1 - a], number[a]) = (number[a], number[n - 1 - a]);
            }

            int reverseI = Convert.ToInt32(number.ToString());
            if ((i - reverseI) % k == 0)
            {
                count++;
            }
            
            i++;
        }

        return count;
    }

}