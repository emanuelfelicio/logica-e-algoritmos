class Result
{

    /*
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
        char[] letras = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
        Dictionary<char, int> alturaDaLetra = [];
        for (int i = 0; i < 26; i++)
        {
            alturaDaLetra[letras[i]] = h[i];
        }


        int largura = word.Length;
        int altura = 0;

        // seleciona maior altura.
        for (int i = 0; i < word.Length; i++)
        {
            altura = Math.Max(altura, alturaDaLetra[word[i]]);

        }
        // retorna área
        return altura * largura;
    }

}