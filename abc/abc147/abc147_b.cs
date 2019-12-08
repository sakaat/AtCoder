// https://atcoder.jp/contests/abc147/submissions/8850430

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine();

            var result = 0;
            for (int i = 0; i < S.Length / 2; i++)
            {
                if (S[i] != S[S.Length - 1 - i])
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
