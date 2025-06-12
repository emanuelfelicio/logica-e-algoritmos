using System.Text;

public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {

        List<string> result = new List<string>();

        int len = s.Length;

        if (len < 4 || len > 12)
        {
            return [];
        }

        for (int i = 1; i < 4 && i < len - 2; i++)
        {
            for (int j = i + 1; j < i + 4 && j < len - 1; j++)
            {
                for (int k = j + 1; k < j + 4 && k < len; k++)
                {
                    string part1 = s[..i];
                    string part2 = s[i..j];
                    string part3 = s[j..k];
                    string part4 = s[k..];

                    if (IsValid(part1) && IsValid(part2) && IsValid(part3) && IsValid(part4))
                    {
                        result.Add($"{part1}.{part2}.{part3}.{part4}");
                    }
                }
            }
        }

        return result;
    }

    static bool IsValid(string s)
    {
        if (s.Length == 0 || s.Length > 3)
            return false;
        if (s.StartsWith("0") && s.Length > 1)
            return false;

        int value = int.Parse(s);
        return value >= 0 && value <= 255;
    }



}

