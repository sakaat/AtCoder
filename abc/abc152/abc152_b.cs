// https://atcoder.jp/contests/abc152/submissions/9608342

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var a = input[0];
            var b = input[1];

            Console.WriteLine(a > b ? new String(char.Parse(b.ToString()), a) : new String(char.Parse(a.ToString()), b));
        }
    }
}
