using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

Solution solution = new Solution();
solution.LetterCombinations("23");
public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {

        IList<string> list = new List<string>();
        Dictionary<char, string> letras = new()
        {
            {'2',"abc" },
            {'3',"def" },
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno" },
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"}
        };

        

        if (string.IsNullOrEmpty(digits)) return list;

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(""); 

        foreach (char digit in digits)
        {
            if (!letras.ContainsKey(digit))
                continue;

            int size = queue.Count;

        
            for (int i = 0; i < size; i++)
            {
                string current = queue.Dequeue();
                foreach (char c in letras[digit])
                {
                    queue.Enqueue(current + c);
                }
            }
        }

    
        while (queue.Count > 0)
        {
           list.Add(queue.Dequeue());
        }

        /* VERSAO RECURSIVA
            void BackTrack(int index, string currentString)
            {
                
                if (currentString.Length == digits.Length)
                {
                    list.Add(currentString);
                    return;
                }

                foreach (var c in letras[digits[index]])
                {
                    BackTrack(index + 1, currentString + c);
                }

            }
        */

        // BackTrack(0, "");

        return list;


       

    }



}