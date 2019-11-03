// https://atcoder.jp/contests/abc133/submissions/8264012

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var L = input[0];
            var R = input[1];

            var min = 2019L;
            var end = false;
            for (var i = L; i < R; i++)
            {
                for (var j = i + 1; j <= R; j++)
                {
                    if (i * j % 2019 < min)
                    {
                        min = i * j % 2019;
                        if (min == 0)
                        {
                            end = true;
                            break;
                        }
                    }
                }
                if (end)
                {
                    break;
                }
            }
            Console.WriteLine(min);
        }
    }
}
