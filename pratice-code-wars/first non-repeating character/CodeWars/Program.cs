using System.Text;

namespace CodeWars;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Kata.FirstNonRepeatingLetter("moonmen"));
    }
}

public static class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        var firstNonRepeatingLetter = "";
        var lowerCaseS = s.ToLower();
        for (int i = 0; i < s.Length; i++)
        {
            var repeatedLetter = false;
            for (var j = 0; j < lowerCaseS.Length; j++)
            {
                if (lowerCaseS[i] == lowerCaseS[j] && i != j)
                {
                    repeatedLetter = true;
                }
            }
        
            if (!repeatedLetter)
            {
                firstNonRepeatingLetter = s[i].ToString();
                break;
            }
        }
        
        return firstNonRepeatingLetter;
        
    }
}