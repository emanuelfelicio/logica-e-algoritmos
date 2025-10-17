using System.Text;

Result.biggerIsGreater("ecdigf");
class Result
{

    /*
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        char[] chars = w.ToCharArray();

      
        int i = chars.Length - 2;
        while (i >= 0 && chars[i] >= chars[i + 1])
            i--;

        if (i < 0)
            return "no answer";

  
        int j = chars.Length - 1;
        while (chars[j] <= chars[i])
            j--;


        (chars[i], chars[j]) = (chars[j], chars[i]);

    
        Array.Reverse(chars, i + 1, chars.Length - (i + 1));
        return new string(chars);

    }

}
