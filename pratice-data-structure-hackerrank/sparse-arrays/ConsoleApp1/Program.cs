
string texto = "hello";
string texto2 = "ariagoto gozaimassu hello";
Console.WriteLine(texto2.Contains(texto));
class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY stringList
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> stringList, List<string> queries)
    {
        List<int> result = new(queries.Count);

        foreach (var querie in queries)
        {

            int i = 0;
            foreach (var list in stringList)
            {
                if (querie == list)
                {
                    i++;
                }
            }
            result.Add(i);
        }
        return result;
    }

}