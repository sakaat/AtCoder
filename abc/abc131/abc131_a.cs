// https://atcoder.jp/contests/abc131/submissions/8291884

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var S = Console.ReadLine();
            if (S[0] == S[1] || S[1] == S[2] || S[2] == S[3])
            {
                Console.WriteLine("Bad");
            }
            else
            {
                Console.WriteLine("Good");
            }
        }
    }
}
