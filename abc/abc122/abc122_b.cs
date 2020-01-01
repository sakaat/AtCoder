// https://atcoder.jp/contests/abc122/submissions/9266697

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine().ToCharArray();

            var result = string.Empty;
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = i; j < S.Length; j++)
                {
                    var temp = string.Empty;
                    for (int k = i; k <= j; k++)
                    {
                        temp += S[k];
                    }
                    if (temp.Length == temp.Count(c => c == 'A' || c == 'C' || c == 'G' || c == 'T'))
                    {
                        if (temp.Length > result.Length)
                        {
                            result = temp;
                        }
                    }
                }
            }
            Console.WriteLine(result.Length);
        }
    }
}
