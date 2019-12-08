// https://atcoder.jp/contests/abc147/submissions/8872688

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var A = new int[N];
            var xy = new int[N][][];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                xy[i] = new int[A[i]][];
                for (int j = 0; j < A[i]; j++)
                {
                    xy[i][j] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }
            }

            var result = 0;
            for (int i = (int)(Math.Pow(2, N) - 1); i >= 0; i--)
            {
                var flag = true;
                var str = Convert.ToString(i, 2).PadLeft(N, '0');

                for (int j = 0; j < N; j++)
                {
                    if (str[j] == '0')
                    {
                        continue;
                    }
                    for (int k = 0; k < A[j]; k++)
                    {
                        if (xy[j][k][1] != str[xy[j][k][0] - 1] - '0')
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    if (str.Count(x => x == '1') > result)
                    {
                        result = str.Count(x => x == '1');
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
