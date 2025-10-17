
public class Solution
{
    public static int LengthOfLastWord(string s)
    {
        int lastWordLength = 0;

        s = s.Trim();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                lastWordLength++;
            }
            else
            {
                break;
            }
        }
        return lastWordLength;
    }
}