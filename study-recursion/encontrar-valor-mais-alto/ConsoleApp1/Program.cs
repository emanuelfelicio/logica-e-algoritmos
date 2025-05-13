int[] numeros = new int[] { 5, 3, 60, 1000, 340, 12, 1, -100 };
int[] numeros2 = new int[] { };

Console.WriteLine(ValorMaisAltoDoArray(numeros2));





static int ValorMaisAltoDoArray(int[] numeros, int index = 0)
{
    // caso base caso array vazio.
    if (numeros.Length == 0)
    {
        return 0;
    }
    // Caso base: Se chegamos ao último elemento, retornamos ele.
    if (index == numeros.Length - 1)
    {
        return numeros[index];
    }
  
  

    // Encontramos o maior número do restante do array
    int maiorNoResto = ValorMaisAltoDoArray(numeros, index + 1);

    // Retorna o maior entre o atual e o maior do restante
    return (numeros[index] > maiorNoResto) ? numeros[index] : maiorNoResto;
}