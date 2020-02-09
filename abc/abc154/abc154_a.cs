// https://atcoder.jp/contests/abc154/submissions/9976033

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var input1 = Console.ReadLine().Split().ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input3 = Console.ReadLine();

            var A = input2[0];
            var B = input2[1];

            if (input3 == input1[0])
            {
                A -= 1;
            }
            else
            {
                B -= 1;
            }

            Console.WriteLine($"{A} {B}");
        }
    }
}
