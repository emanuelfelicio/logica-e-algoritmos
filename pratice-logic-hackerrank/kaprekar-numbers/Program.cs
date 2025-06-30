using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

Result.kaprekarNumbers(0, 7777);
class Result
{

    /*
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        StringBuilder sb = new();
        for (int i = p; i <= q; i++)
        {
            if (isKaprekarNumber(i))
            {
                sb.Append($"{i} ");
            }
        }

        if (sb.Length == 0)
        {
            System.Console.WriteLine("INVALID RANGE");

        }
        else
        {
            System.Console.WriteLine(sb);
        }
    }

    public static bool isKaprekarNumber(int number)
    {
        string squareNumber = Math.Pow(number, 2).ToString();
        string firstHalf = squareNumber[..(squareNumber.Length / 2)];
        string secondeHalf = squareNumber[firstHalf.Length..];

        int.TryParse(firstHalf, out int first);
        int.TryParse(secondeHalf, out int second);

        return first + second == number;
    }

}
