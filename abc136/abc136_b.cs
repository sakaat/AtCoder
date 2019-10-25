// https://atcoder.jp/contests/abc136/submissions/8119388

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var result = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i.ToString().Length % 2 == 1)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
