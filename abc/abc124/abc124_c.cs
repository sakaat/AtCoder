// https://atcoder.jp/contests/abc124/submissions/8434239

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var S = Console.ReadLine();

            var result1 = 0;
            var result2 = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if ((i % 2 == 0 ? '0' : '1') != S[i])
                {
                    result1++;
                }
                if (((i + 1) % 2 == 0 ? '0' : '1') != S[i])
                {
                    result2++;
                }
            }
            Console.WriteLine(Math.Min(result1, result2));
        }
    }
}
