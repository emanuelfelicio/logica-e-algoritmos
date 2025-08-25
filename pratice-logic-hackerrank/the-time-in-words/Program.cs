using System.Diagnostics;
using System.Text;

class Result
{

    /*
     * Complete the 'timeInWords' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER h
     *  2. INTEGER m
     */

    public static string timeInWords(int h, int m)
    {
        Dictionary<int, string> numberTo = new() {
            { 1,"one"},
            { 2,"two"},
            {3,"three"},
            {4,"four"},
            {5,"five"},
            {6,"six"},
            {7,"seven"},
            {8,"eight"},
            {9,"nine"},
            {10,"ten"},
            {11,"eleven"},
            {12,"twelve"},
            {13,"thirteen"},
            {14,"fourteen"},
            {15,"quarter"},
            {16,"sixteen"},
            {17,"seventeen"},
            {18,"eighteen"},
            {19,"nineteen"},
            {20,"twenty"},
            {21,"twenty one"},
            {22,"twenty two"},
            {23,"twenty three"},
            {24 ,"twenty four"},
            {25 ,"twenty five"},
            {26 ,"twenty six"},
            {27,"twenty seven"},
            {28, "twenty eight"},
            {29,"twenty nine"},
            {30,"half"}
    };

        StringBuilder result = new();
        const int oneHour = 60;
        const int half = 30;
        const int quarter = 15;
     
    
        if (m == 0)
        {
            return $"{numberTo[h]} o' clock";
        }
        

        if (m <= half)
        {
            result.Append($"{numberTo[m]}");

            if (m == 1)
            {
                result.Append(" minute");
            }
            else
            {
                if (m != half && m != quarter)
                {
                    result.Append(" minutes");
                }

            }

            result.Append($" past {numberTo[h]}");
        }
        else
        {
            int minutes = oneHour - m;
            result.Append($"{numberTo[minutes]}");

            if (minutes != quarter)
            {
                result.Append(" minutes");
            }
            result.Append($" to {numberTo[h + 1]}");
        }

        return result.ToString();

    }

}