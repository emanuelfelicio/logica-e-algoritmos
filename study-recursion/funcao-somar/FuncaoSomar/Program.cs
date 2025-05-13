

int[] numeros = [1, 2, 3, 4];
int[] vazio = [];
List<int> numeros2 = [1, 2, 3, 4];
Console.WriteLine(SomaRecursiva(vazio));






static int SomaRecursiva(int[] arr, int index = 0)
{
    if (index == arr.Length)
        return 0;
    return arr[index] + SomaRecursiva(arr, index + 1);
}

/* essa recursão em somar lista funciona, mas por ser um tipo de referência os elementos serão d
e fato modificados fora da função o que nesse caso fará com que a lista fique vazia*/

static int SomaLista(List<int> list)
{
    if (list.Count == 0)
    {
        return 0;
    }
    int soma = list[0];
    list.RemoveAt(0);
    return soma + SomaLista(list);
}