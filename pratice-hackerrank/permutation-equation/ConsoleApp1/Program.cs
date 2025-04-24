using System.Security.Cryptography.X509Certificates;

class Result
{

    /*
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */

    public static List<int> permutationEquation(List<int> p)
    {
        List<int> result = [];

        int x = 0;
        for (int i = 0; i < p.Count; i++)
        {
            x++;
            int positionOfX = LinearSearch(p, x) + 1;
            int positionOfY = LinearSearch(p, positionOfX) + 1;
            result.Add(positionOfY);

        }

        return result;
    }

    public static int LinearSearch(List<int> p, int value)
    {
        int index = 0;
        for (int i = 0; i < p.Count; i++)
        {
            if (p[i] == value)
            {
                index = i;
                break;
            }
        }
        return index;
    }

}