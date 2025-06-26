
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLen = 0;
        int left = 0;
        var map = new Dictionary<char, int>();

        for (int right = 0; right < n; right++)
        {
            char c = s[right];
            if (map.TryGetValue(c, out int value))
            {
                left = Math.Max(value + 1, left);
            }
            map[c] = right;
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}