// https://atcoder.jp/contests/abc146/submissions/8613529

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            char[] a = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                         'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < S.Length; i++)
            {
                var index = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == S[i])
                    {
                        index = j;
                        break;
                    }
                }
                Console.Write(a[index + N]);
            }
            Console.WriteLine();
        }
    }
}
