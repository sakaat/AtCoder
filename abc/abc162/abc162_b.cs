// https://atcoder.jp/contests/abc162/submissions/11818801

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = long.Parse(Console.ReadLine());

            var result = 0L;
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 > 0 && i % 5 > 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
