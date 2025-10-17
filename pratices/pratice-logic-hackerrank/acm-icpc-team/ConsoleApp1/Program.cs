using System.Data.Common;

class Result
{

    /*
     * Complete the 'acmTeam' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts STRING_ARRAY topic as parameter.
     */

    public static List<int> acmTeam(List<string> topic)
    {
    
        int maxQuestions = 0;
        int group = 0;

        for (int i = 0; i < topic.Count; i++)
        {
            for (int j = i + 1; j < topic.Count; j++)
            {
                int countNumberOneInString = 0;
                for (int k = 0; k < topic[i].Length; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                    {
                        countNumberOneInString++;
                    }
                }
                if (countNumberOneInString > maxQuestions)
                {

                    maxQuestions = countNumberOneInString;
                    group = 1;

                }
                else if (countNumberOneInString == maxQuestions)
                {
                    group++;
                }
            }
        }

        return [maxQuestions, group];
    }

}