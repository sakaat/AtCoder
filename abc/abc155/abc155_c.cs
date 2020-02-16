// https://atcoder.jp/contests/abc155/submissions/10164444

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var S = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine();
                if (S.ContainsKey(input))
                {
                    S[input]++;
                }
                else
                {
                    S.Add(input, 1);
                }
            }
            var sorted_S = S.OrderByDescending(x => x.Value);

            var count = 0;
            var slist = new List<string>();
            foreach (var s in sorted_S)
            {
                if (S[s.Key] < count)
                {
                    break;
                }
                slist.Add(s.Key);
                count = S[s.Key];
            }

            var sorted_slist = slist.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);
            foreach (var s in sorted_slist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
