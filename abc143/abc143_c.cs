// https://atcoder.jp/contests/abc143/submissions/8107540

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            var d = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (S[i] == S[i + 1])
                {
                    d++;
                }
            }
            Console.WriteLine(N - d);
        }
    }
}
