// https://atcoder.jp/contests/abc158/submissions/10646112

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine();
            var Q = int.Parse(Console.ReadLine());

            var flag = true;
            var ll = new LinkedList<char>();
            ll.AddLast('*');

            for (int i = 0; i < Q; i++)
            {
                var input = Console.ReadLine();
                if (input[0] == '1')
                {
                    if (flag)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    continue;
                }
                var q = input.Split().ToArray();
                if (flag)
                {
                    if (q[1] == "1")
                    {
                        ll.AddFirst(char.Parse(q[2]));
                    }
                    else
                    {
                        ll.AddLast(char.Parse(q[2]));
                    }
                }
                else
                {
                    if (q[1] == "1")
                    {
                        ll.AddLast(char.Parse(q[2]));
                    }
                    else
                    {
                        ll.AddFirst(char.Parse(q[2]));
                    }
                }
            }

            var str = new string(ll.ToArray()).Replace("*", S);
            Console.WriteLine(flag ? str : new string(str.Reverse().ToArray()));
        }
    }
}
