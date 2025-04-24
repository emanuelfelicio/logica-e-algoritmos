

Console.WriteLine(Kata.Solution(20));

public static class Kata
{
    public static int Solution(int value)
    {
        int numero = 1;
        int sum = 0;

        while (numero * 3 < value)
        {
            sum += numero * 3;

            // verifica se multiplo de 5 é valido e também se é divisível por 3 e 5 ao mesmo tempo
            if (numero * 5 < value && numero * 5 % 3 != 0)
            {
                sum += numero * 5;
            }

            numero++;
        }

        return sum;
    }



}
