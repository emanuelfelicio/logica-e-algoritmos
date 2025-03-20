class Result
{

    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int fairlyPrice = 0;
        for (int i = 0; i < bill.Count; i++)
        {
            fairlyPrice += bill[i];
        }
        //retirando o que ela não comeu
        fairlyPrice -= bill[k];
        // calculando preço que ana deve pagar
        fairlyPrice /= 2;

        if (fairlyPrice == b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine($"{b - fairlyPrice}");
        }
    }

}