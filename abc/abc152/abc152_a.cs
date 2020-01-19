// https://atcoder.jp/contests/abc152/submissions/9604731

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(input[0] == input[1] ? "Yes" : "No");
        }
    }
}
