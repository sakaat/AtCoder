// https://atcoder.jp/contests/abc168/submissions/13394129

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var A = input[0];
            var B = input[1];
            var H = input[2];
            var M = input[3];

            var hour = 30 * H + 0.5 * M;
            var minute = 6 * M;
            var angle = Math.Abs(hour - minute);
            var radian = angle * Math.PI / 180;

            Console.WriteLine(Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(radian)));
        }
    }
}
