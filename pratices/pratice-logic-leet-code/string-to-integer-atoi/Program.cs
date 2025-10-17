using System.ComponentModel;

Solution solution = new();
solution.MyAtoi(" ");

public class Solution
{
    public int MyAtoi(string s)
    {

        string number = "";
        bool isNegative = false;
        int i = 0;

        while (i < s.Length && s[i] == ' ')
        {
            i++;
        }
        if (i < s.Length)
        {

            if (s[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else
            {
                if (s[i] == '+')
                {
                    i++;
                }
            }
        }

        while (i < s.Length)
        {

            if (s[i] >= '0' && s[i] <= '9')
            {
                // skip leading zero
                if (number.Length == 0 && s[i] != '0')
                {
                    number += s[i];
                }
                else
                {
                    number += s[i];
                }

            }
            else
            {
                break;
            }
            i++;
        }
        int result = 0;
        if (number.Length > 0)
        {
            try
            {
                result = int.Parse(number);

                if (isNegative)
                {
                    result *= -1;
                }
            }

            catch (Exception)
            {
                if (isNegative)
                {
                    result = int.MinValue;
                }
                else
                {
                    result = int.MaxValue;
                }
            }
        }

        return result;

    }
}