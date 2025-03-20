using System.Text;

class Result
{

    /*
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     *  3. INTEGER k
     */

    public static string appendAndDelete(string s, string t, int k)
    {
        int letrasIguais = 0;
        int sPointer = 0;
        int QuantidaDeRemocoes = 0;
        int QuantidadeDeAcrescimos = 0;
        int operacoes = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (sPointer < s.Length)
            {
                if (s[i] == t[i])
                {
                    letrasIguais++;
                    sPointer++;
                }
                else
                {
                    break;
                }
            }

        }
        if (s.Length <= t.Length)
        {
            QuantidaDeRemocoes = s.Length - letrasIguais;
            QuantidadeDeAcrescimos = t.Length - letrasIguais;
            operacoes = QuantidadeDeAcrescimos + QuantidaDeRemocoes;
        }
       
       

        if (operacoes <= k)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }

    }

}