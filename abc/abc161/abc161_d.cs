// https://atcoder.jp/contests/abc161/submissions/11612594

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var K = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            for (var i = 1; i <= 9; i++)
            {
                queue.Enqueue(i);
            }

            var n = 0L;
            for (var i = 1; i <= K; i++)
            {
                n = queue.Dequeue();
                if (n % 10 != 0)
                {
                    queue.Enqueue(n * 10 + n % 10 - 1);
                }
                queue.Enqueue(n * 10 + n % 10);
                if (n % 10 != 9)
                {
                    queue.Enqueue(n * 10 + n % 10 + 1);
                }
            }
            Console.WriteLine(n);
        }
    }
}
