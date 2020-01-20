// https://atcoder.jp/contests/past201912-open/submissions/9641012

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var S = Console.ReadLine();
            var words = new List<string>();

            var io = 0;
            var count = 0;
            var flag = false;
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsUpper(S[i]))
                {
                    if (flag)
                    {
                        words.Add(S.Substring(io, count + 1));
                        io = i + 1;
                        count = 0;
                        flag = false;
                        continue;
                    }
                    flag = true;
                }
                count++;
            }
            words.Sort();

            foreach (var w in words)
            {
                Console.Write(w);
            }
        }
    }
}
