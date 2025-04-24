public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        if (strs.Length == 0)
        {
            return "";
        }

        string palvras = "";
        int j = 0;
        bool found;
        for (int i = 0; i < strs.Length - 1; i++)
        {
            if (strs[i].Length != 0 && strs[i+1].Length != 0)
            {
                /*
                    if(strs[i][j] != strs[i + 1][j])
                    {
                        found = false;
                    }
                */
            }
            else
            {
                palvras = "";
                break;
            }
             if(i+2 == strs.Length ||)

        }

        return palvras;
    }
}