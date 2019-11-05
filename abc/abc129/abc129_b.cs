// https://atcoder.jp/contests/abc129/submissions/8303193

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var W = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var l = W.Sum();
            var r = 0;
            var temp = l - r;
            for (int i = N - 1; i >= 0; i--)
            {
                l -= W[i];
                r += W[i];
                if (temp < Math.Abs(l - r))
                {
                    break;
                }
                else
                {
                    temp = Math.Abs(l - r);
                }
            }
            Console.WriteLine(temp);
        }
    }
}
