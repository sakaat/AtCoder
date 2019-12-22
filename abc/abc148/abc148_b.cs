// https://atcoder.jp/contests/abc148/submissions/9064589

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ').ToArray();
            var S = input[0];
            var T = input[1];

            var result = string.Empty;
            for (int i = 0; i < N; i++)
            {
                result += S[i].ToString() + T[i].ToString();
            }
            Console.WriteLine(result);
        }
    }
}
