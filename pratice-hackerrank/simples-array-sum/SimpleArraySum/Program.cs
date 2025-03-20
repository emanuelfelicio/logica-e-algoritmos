
// receber input 
// fazer um loop que soma e reatribui o valor da lista para uma variável "Sum" 
// retornar Sum 


static int simpleArraySum(List<int> ar)
{

    int sum = 0;
    for (int i = 0; i < ar.Capacity; i++)
    {
        sum += ar[i];
    }

    return sum;
}



