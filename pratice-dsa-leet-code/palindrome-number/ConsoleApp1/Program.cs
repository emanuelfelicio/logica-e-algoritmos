public class Solution
{
    // solucao 01: menos eficiente
    public bool IsPalindrome(int x)
    {
        string s1 = x.ToString();
        string s2 = "";

        for (int i = s1.Length - 1; i >= 0; i--)
        {
            s2 += s1[i].ToString();
        }

        if (s2.Equals(s1))
        {
            return true;
        }
        return false;

    }

    //solucao 02: mais eficiente
    public bool IsPalindrome2(int x)
    {

        string s1 = x.ToString();
        for (int i = 0; i < s1.Length / 2; i++)
        {
            if (s1[i] != s1[s1.Length - 1 - i])
            {
                return false;
            }
        }
        return true;

    }
}