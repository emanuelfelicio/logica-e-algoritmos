class Result
{


    public static List<int> breakingRecords(List<int> scores)
    {
        int scoreMin = scores[0];
        int scoreMax = scores[0];
        int minCount = 0;
        int maxCount = 0;
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] < scoreMin)
            {
                minCount++;
                scoreMin = scores[i];
            }
            if (scores[i] > scoreMax)
            {
                maxCount++;
                scoreMax = scores[i];
            }
        }

        return new List<int> { scoreMin, scoreMax };
    }

}