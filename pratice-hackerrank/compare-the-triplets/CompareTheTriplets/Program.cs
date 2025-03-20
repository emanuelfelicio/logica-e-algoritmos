// fazer um loop e comparar valores das duas Lista, acresentando pontuação a
//
// retornar uma lista contendo dois valores, um valor com a pontuação de Alice e outro valor a pontuação de Bob


List<int> result = new List<int> { 3, 4, 5 };

List<int> result2 = new List<int> { 1, 2, 3 };

var list = compareTriplets(result, result2);
foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}


static List<int> compareTriplets(List<int> a, List<int> b)
{


    List<int> result = [0, 0];

    for (int i = 0; i < a.Count; i++)
    {

        if (a[i] > b[i])
        {
            result[0] += 1;
        }
        else if (a[i] < b[i])
        {
            result[1] += 1;
        }

    }
    return result;
}

