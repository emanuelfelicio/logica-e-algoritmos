using System.Text;

Result.encryption("feedthedog");

class Result
{
    /*
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        s = s.Replace(" ", "");
        int l = s.Length;
        int row = (int)Math.Floor(Math.Sqrt(l));
        int collumn = (int)Math.Ceiling(Math.Sqrt(l));


        if (row * row >= l)
        {
            collumn = row;
        }


        StringBuilder result = new StringBuilder();
        for (int i = 0; i < collumn; i++)
        {
            for (int j = i; j < s.Length; j += collumn)
            {
                result.Append(s[j]);
            }

            result.Append(' ');
        }

        return result.ToString().TrimEnd();
    }
}