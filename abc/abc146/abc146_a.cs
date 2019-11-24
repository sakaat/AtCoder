// https://atcoder.jp/contests/abc146/submissions/8605371

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var S = Console.ReadLine();

            if (S == "SAT")
            {
                Console.WriteLine(1);
            }
            else if (S == "FRI")
            {
                Console.WriteLine(2);
            }
            else if (S == "THU")
            {
                Console.WriteLine(3);
            }
            else if (S == "WED")
            {
                Console.WriteLine(4);
            }
            else if (S == "TUE")
            {
                Console.WriteLine(5);
            }
            else if (S == "MON")
            {
                Console.WriteLine(6);
            }
            else if (S == "SUN")
            {
                Console.WriteLine(7);
            }
        }
    }
}
