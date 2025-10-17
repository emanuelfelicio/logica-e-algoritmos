

long test = long.MaxValue/int.MaxValue;

Result.taumBday(3, 6, int.MaxValue, int.MaxValue, 2);

class Result
{

    /*
     * Complete the 'taumBday' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER b
     *  2. INTEGER w
     *  3. INTEGER bc
     *  4. INTEGER wc
     *  5. INTEGER z
     */

    public static long taumBday(int b, int w, int bc, int wc, int z)
    {

        long result;
        long bQuantity = b;
        long wQuantity = w;
        long bcQuantity = bc;
        long wcQuantity = wc;
        long zQuantity = z;
        if (bcQuantity + zQuantity <= wcQuantity)
        {
            result = bQuantity * bcQuantity + (bcQuantity + zQuantity) * wQuantity;
        }
        else if (wcQuantity + zQuantity <= bcQuantity)
        {
            result = wQuantity * wcQuantity + (wcQuantity + zQuantity) * bQuantity;
        }
        else
        {
            result = wQuantity * wcQuantity + bQuantity * bcQuantity;
        }

        return result;
    }

    // versão melhorada
    /*
        long bp = Math.Min(bc, wc+z);
        long wp = Math.Min(wc, bc + z);
        return bp * b + wp * w;
    */
}