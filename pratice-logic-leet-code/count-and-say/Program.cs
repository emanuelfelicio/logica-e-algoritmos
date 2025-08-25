using System.Text;

Solution solution = new();
solution.CountAndSay(5);
public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        string result = "1";
        for (int i = 2; i <= n; i++)
        {
            result = Rle(result);
        }

        return result;

        string Rle(string input)
        {
            StringBuilder output = new();
            int count = 1;
            char previous = input[0];


            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    output.Append(count).Append(previous);
                    previous = input[i];
                    count = 1;
                }
            }
            output.Append(count).Append(previous);
            return output.ToString();

        }
    }
}