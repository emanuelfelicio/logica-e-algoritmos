class Result
{

    /*
     * Complete the 'libraryFine' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER d1
     *  2. INTEGER m1
     *  3. INTEGER y1
     *  4. INTEGER d2
     *  5. INTEGER m2
     *  6. INTEGER y2
     */

    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        int fine = 0;
        if (y1 == y2)
        {
            if (m1 == m2)
            {
                if (d1 > d2)
                {
                    fine = 15 * (d1 - d2);
                    return fine;
                }
                else 
                {
                    return 0;
                }

            }
            else if (m1 < m2)
            {
                return 0;
            }
            else
            {
                fine = 500 * (m1 - m2);
                return fine;
            }
        }
        else if (y1 < y2)
        {
            return 0;
        }
        else
        {
            return 10000;
        }

    }
}