// https://atcoder.jp/contests/abc136/submissions/8119634

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var H = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = true;
            for (int i = N - 1; i > 0; i--)
            {
                if (H[i] + 1 < H[i - 1])
                {
                    result = false;
                    break;
                }
                else if (H[i] + 1 == H[i - 1])
                {
                    H[i - 1]--;
                }
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
