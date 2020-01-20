// https://atcoder.jp/contests/past201912-open/submissions/9640478

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = input[0];
            var Q = input[1];

            var table = new char[N][];
            for (int i = 0; i < N; i++)
            {
                table[i] = new char[N];
                for (int j = 0; j < N; j++)
                {
                    table[i][j] = 'N';
                }
            }

            for (int i = 0; i < Q; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (input[0])
                {
                    case 1:
                        table[input[1] - 1][input[2] - 1] = 'Y';
                        break;
                    case 2:
                        for (int j = 0; j < N; j++)
                        {
                            if (table[j][input[1] - 1] == 'Y')
                            {
                                table[input[1] - 1][j] = 'Y';
                            }
                        }
                        break;
                    case 3:
                        var follower = new char[N];
                        Array.Copy(table[input[1] - 1], follower, N);
                        for (int j = 0; j < N; j++)
                        {
                            if (follower[j] == 'Y')
                            {
                                for (int k = 0; k < N; k++)
                                {
                                    if (table[j][k] == 'Y')
                                    {
                                        table[input[1] - 1][k] = 'Y';
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(i == j ? 'N' : table[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
