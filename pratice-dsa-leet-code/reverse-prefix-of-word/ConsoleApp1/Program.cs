using System.IO.Pipelines;

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        Stack<char> stack = new();
        bool found = false;
        string result = "";
        for (int i = 0; i < word.Length; i++)
        {
            stack.Push(word[i]);

            if (word[i] == ch)
            {
                found = true;
                break;
            }

        }

        for (int i = 0; i < word.Length; i++)
        {
            if (stack.Count > 0 && found)
            {
                result += stack.Pop().ToString();
            }
            else
            {
                result += word[i].ToString();
            }
        }
        return result;

    }
}