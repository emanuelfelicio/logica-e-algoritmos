
using System.Text;

public class Solution
{
    public static string AddBinary(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        char carry = '0';
        Stack<char> stack = new();

        while (i >= 0 || j >= 0 || carry != '0')
        {
            char valueA = i >= 0 ? a[i] : '0';
            char valueB = j >= 0 ? b[j] : '0';
            if (carry == '0')
            {
                if ((valueA == '1' || valueB == '1') && (valueA == '0' || valueB == '0'))
                {
                    stack.Push('1');
                    carry = '0';
                }
                else if (valueA == '1' && valueB == '1')
                {
                    stack.Push('0');
                    carry = '1';
                }
                else
                {
                    stack.Push('0');
                    carry = '0';
                }
            }
            else
            {
                if ((valueA == '1' || valueB == '1') && (valueA == '0' || valueB == '0'))
                {
                    stack.Push('0');
                    carry = '1';
                }
                else if (valueA == '1' && valueB == '1')
                {
                    stack.Push('1');
                    carry = '1';
                }
                else
                {
                    stack.Push(carry);
                    carry = '0';
                }
            }
            i--;
            j--;
        }
        string result = new([.. stack]);
        return result;

    }
}
