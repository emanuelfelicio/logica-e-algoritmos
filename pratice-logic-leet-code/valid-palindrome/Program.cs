
using System.Text;

public class Solution
{
    public bool IsPalindrome(string s)
    {

        StringBuilder builder = new();

        s = s.ToLower();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (isValidAlhphanumeric(c))
            {
                builder.Append(c);
            }
        }

        int left = 0;
        int right = builder.Length - 1;

        while (left < right)
        {
            if (builder[left] == builder[right])
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }

        }

        return true;


    }
    public bool isValidAlhphanumeric(int value)
    {
        if ((value >= 97 && value <= 122) || (value >= 48 && value <= 57))
        {
            return true;
        }

        return false;
    }
}