// https://atcoder.jp/contests/abc153/submissions/9740398

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = input[0];
            var N = input[1];

            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                H -= A[i];
            }
            Console.WriteLine(H <= 0 ? "Yes" : "No");
        }
    }
}
