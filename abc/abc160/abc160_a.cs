// https://atcoder.jp/contests/abc160/submissions/11314948

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine();

            if (S[2] == S[3] && S[4] == S[5])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
