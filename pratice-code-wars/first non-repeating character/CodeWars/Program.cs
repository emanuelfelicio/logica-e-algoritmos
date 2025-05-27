
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
        Dictionary<char, int> dict = [];
        foreach (char caractere in s)
        {
            if (!dict.TryGetValue(caractere, out int num))
            {
                dict.Add(caractere, 1);
            }
            else
            {
                dict[caractere] = num + 1;
            }
        }

        foreach (var caractere in s)
        {
            if (dict[caractere] == 1)
            {
                return caractere.ToString();
            }
        }

        return "";

    }
}