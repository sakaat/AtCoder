// https://atcoder.jp/contests/abc128/submissions/8389684

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];

            var s = new int[M][];
            for (int i = 0; i < M; i++)
            {
                s[i] = Console.ReadLine().Split(' ').Select(int.Parse).Skip(1).ToArray();
            }

            var p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = 0;
            for (int i = 0; i < Math.Pow(2, N); i++)
            {
                var c = Convert.ToString(i, 2).PadLeft(N, '0').ToCharArray();

                var flag = true;
                for (int j = 0; j < M; j++)
                {
                    var temp = 0;
                    for (int k = 0; k < s[j].Length; k++)
                    {
                        temp += c[s[j][k] - 1];
                    }
                    if (temp % 2 != p[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
