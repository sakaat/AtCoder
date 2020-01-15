// https://atcoder.jp/contests/past201912-open/submissions/9525315

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(input);
            Console.WriteLine(input[3]);
        }
    }
}
