public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            int value = 1;


            for (int j = 0; j < word.Length; j++)
            {
                if (!allowed.Contains(word[j]))
                {
                    value--;
                    break;
                }
            }
            count += value;
        }

        return count;


    }
}