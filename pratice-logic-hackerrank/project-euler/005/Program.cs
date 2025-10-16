using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

Solution.FindNumber(10);
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

        }
    }

    public static void FindNumber(int n)
    {
        int res = 1;
        for (int i = 1; i <= n; i++)
        {
            res = Mmc(res, i);
        }
        Console.WriteLine(res);
    }

    private static int Mdc(int a, int b)
    {
        while (b != 0)
        {
            int resto = a % b;
            a = b;
            b = resto;
        }
        return a;
    }
    private static int Mmc(int a, int b)
    {
        return a / Mdc(a, b) * b;
    }
}