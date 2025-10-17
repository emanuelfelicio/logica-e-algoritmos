Solution s = new();

s.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {

        // Dictionary<string, IList<string>> r = new();
        // foreach (string s in strs)
        // {
        //     char[] c = new char[26];
        //     foreach (char sc in s)
        //     {
        //         c[sc - 'a']++;
        //     }
        //     var key = new string(c);
        //     if (!r.ContainsKey(key))
        //     {
        //         r[key] = new List<string>();

        //     }
        //     r[key].Add(s);
        // }
        // return r.Values.ToList<IList<string>>();

        Dictionary<string, List<string>> anagramsGroupToPosition = new();

        foreach (var str in strs)
        {

            char[] c = str.ToCharArray();
            Array.Sort(c);
            string s = new string(c);

            if (anagramsGroupToPosition.TryGetValue(s, out var s1))
            {
                s1.Add(str);
            }
            else
            {
                anagramsGroupToPosition.Add(s, [str]);
            }
        }

        return anagramsGroupToPosition.Values.ToArray();
    }
}