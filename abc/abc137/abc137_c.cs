// https://atcoder.jp/contests/abc137/submissions/7962505

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, int>();

            var result = 0L;
            for (int i = 0; i < N; i++)
            {
                var s = Console.ReadLine();

                var array = s.ToCharArray();
                Array.Sort(array);
                s = new string(array);

                if (dic.ContainsKey(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic[s] = 0;
                }

                result += dic[s];
            }

            Console.WriteLine(result);
        }
    }
}
