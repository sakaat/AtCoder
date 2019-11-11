// https://atcoder.jp/contests/abc126/submissions/8399610

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var S = int.Parse(Console.ReadLine());
            var l = S / 100;
            var r = S % 100;

            if (1 <= l && l <= 12)
            {
                if (1 <= r && r <= 12)
                {
                    Console.WriteLine("AMBIGUOUS");
                }
                else
                {
                    Console.WriteLine("MMYY");
                }
            }
            else if (1 <= r && r <= 12)
            {
                Console.WriteLine("YYMM");
            }
            else
            {
                Console.WriteLine("NA");
            }
        }
    }
}
