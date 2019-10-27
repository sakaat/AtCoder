// https://atcoder.jp/contests/abc144/submissions/8152532

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var result = false;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (i * j == N)
                    {
                        result = true;
                        break;
                    }
                }
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
