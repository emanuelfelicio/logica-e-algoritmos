
char[] letras = ['a', 'b', 'c',];
char[] letras2 = ['d', 'e'];
Solution.ReverseString(letras);

Console.WriteLine(letras);

public class Solution
{
    public static void ReverseString(char[] s)
    {
        int j = 0;
        for (int i = s.Length - 1; i >= (s.Length / 2); i--)
        {

            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            j++;

        }
    }
}
