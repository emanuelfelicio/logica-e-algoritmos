using System.Text;
using System.Xml.XPath;

Solution solutio = new();
solutio.ConvertToTitle(701);
public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        List<char> str = new();
        while (columnNumber > 0)
        {
            // columnNumber--;
            char c = (char)('A' + columnNumber % 26);
            str.Add(c);
            columnNumber /= 26;
        }
        str.Reverse();
         
        return new string(str.ToArray());
        
    }
}