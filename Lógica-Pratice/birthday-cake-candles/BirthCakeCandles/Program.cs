/*  
    o input é uma lista contendo as alturas de velas
    saber qual é a vela de maior altura contar quantas vezes essa vela d se repete e atribuir este valor variavel count
    retornar count

    passos 
    1) ordenar a lista
    2) 
*/


static int birthdayCakeCandles(List<int> candles)
{
    candles.Sort();
    int n = candles.Count;
    int tallestCandles = candles[n - 1];
    int count = 0;
    for (int i = candles.Count - 1; i >= 0; i--)
    {
        if (candles[i] == tallestCandles)
        {
            count++;
        }
        else
        {
            break;
        }
    }

    return count;
}