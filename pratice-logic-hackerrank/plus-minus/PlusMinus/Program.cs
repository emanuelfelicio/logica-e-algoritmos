// o parâmetro é um array de inteiros
//obter tamanho N do array
// fazer loop e obter as seguintes variaveis :
//Obter numeros quantidade de numeros positivos no array e atributi a variável positives
//Obter numeros quantidade de numeros negativos no array e atributi a variável negatives
//obter quantos zero existem no array e atribuir a variável zeros
//o método deve printar positive/N negative/N zeros/N com precisão de 6 casas decimais


static void plusMinus(List<int> arr)
{
    int n = arr.Count;
    decimal positives = 0;
    decimal negatives = 0;
    decimal zeros = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] > 0)
        {
            positives++;
        }
        else if (arr[i] < 0)
        {
            negatives++;
        }
        else
        {
            zeros++;
        }
    }
    Console.WriteLine($"{positives / n:F6}\n{negatives / n:F6}\n{zeros / n:F6}");
}