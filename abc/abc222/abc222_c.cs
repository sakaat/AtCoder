// https://atcoder.jp/contests/abc222/submissions/26805894

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];

        var A = new char[2 * N][];
        var rank = new P[2 * N];
        for (int i = 0; i < 2 * N; i++)
        {
            A[i] = Console.ReadLine().ToCharArray();
            rank[i] = new P(i);
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                var r = judge(A[rank[2 * j].id][i], A[rank[2 * j + 1].id][i]);
                if (r >= 0)
                {
                    rank[2 * j + r].count++;
                }
            }
            rank = rank.OrderByDescending(x => x.count).ThenBy(x => x.id).ToArray();
        }

        for (int i = 0; i < 2 * N; i++)
        {
            Console.WriteLine(rank[i].id + 1);
        }
    }

    static int judge(char x, char y)
    {
        if (x == y)
        {
            return -1;
        }
        else if (x == 'G' && y == 'P'
              || x == 'C' && y == 'G'
              || x == 'P' && y == 'C')
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    class P
    {
        public int id;
        public int count = 0;
        public P(int id) { this.id = id; }
    }
}
