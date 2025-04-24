using System.Text;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dictonary = new()
        {
            {']','['},
            {')','('},
            {'}','{'}
        };

        foreach (char c in s)
        {
            if (dictonary.ContainsKey(c))
            {
                if (stack.Count != 0 && stack.Peek() == dictonary[c])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}