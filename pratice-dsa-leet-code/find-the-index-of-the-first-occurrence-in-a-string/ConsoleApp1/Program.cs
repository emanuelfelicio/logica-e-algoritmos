using System.ComponentModel.Design.Serialization;

Solution solution = new Solution();
solution.StrStr("mississippi", "sippia");

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        //return haystack.IndexOf(needle);

        int result = 0;
        bool found = false;

        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (haystack.Length - i  >= needle.Length)
                {
                    found = true;
                    int k = i;

                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (k < haystack.Length)
                        {
                            if (haystack[k] != needle[j])
                            {
                                found = false;
                                break;
                            }
                            k++;
                        }
                    }
                }


            }
            if (found == true)
            {
                result = i;
                break;
            }
            else
            {
                result = -1;
            }
        }
        return result;
    }
}