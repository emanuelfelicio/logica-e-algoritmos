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
        int tamanhoT = t.Length;
        int tamanhoS = s.Length;
        for (int i = 0; i < tamanhoT; i++)
        {
            if (letrasIguais < tamanhoS)
            {
                if (s[i] == t[i])
                {
                    letrasIguais++;

                }
                else
                {
                    break;
                }
            }

        }
        int operacoesMinimas = tamanhoS - letrasIguais + tamanhoT - letrasIguais;


    
 
        
        
        if (k < operacoesMinimas)
        {
            return "No";
        }
        
        else if ((k - operacoesMinimas) % 2 == 0 || k >= tamanhoS + tamanhoT)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }


    }

}