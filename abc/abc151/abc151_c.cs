// https://atcoder.jp/contests/abc151/submissions/9465044

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var M = input[1];

            var p = new int[M];
            var S = new string[M];
            for (int i = 0; i < M; i++)
            {
                var input2 = Console.ReadLine().Split(' ').ToArray();
                p[i] = int.Parse(input2[0]);
                S[i] = input2[1];
            }

            var ac = 0;
            var wa = 0;
            var waa = new int[N];
            var flags = new bool[N];

            for (int i = 0; i < M; i++)
            {
                if (!flags[p[i] - 1])
                {
                    if (S[i] == "WA")
                    {
                        waa[p[i] - 1]++;
                    }
                    else if (S[i] == "AC")
                    {
                        wa += waa[p[i] - 1];
                        ac++;
                        flags[p[i] - 1] = true;
                    }
                }
            }
            Console.WriteLine($"{ac} {wa}");
        }
    }
}
