// https://atcoder.jp/contests/abc216/submissions/25506701

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        var st = new string[N];

        for (int i = 0; i < N; i++)
        {
            st[i] = Console.ReadLine();
        }
        Console.WriteLine(st.Distinct().Count() == N ? "No" : "Yes");
    }
}
