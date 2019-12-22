// https://atcoder.jp/contests/abc148/submissions/9056864

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());

            if (A + B == 3)
            {
                Console.WriteLine("3");
            }
            else if (A + B == 4)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
