// https://atcoder.jp/contests/past202004-open/submissions/13444556

using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var floors = new List<string> { "B9", "B8", "B7", "B6", "B5", "B4", "B3", "B2", "B1", "1F", "2F", "3F", "4F", "5F", "6F", "7F", "8F", "9F", };

            var input = Console.ReadLine().Split();
            var S = input[0];
            var T = input[1];

            Console.WriteLine(Math.Abs(floors.IndexOf(S) - floors.IndexOf(T)));
        }
    }
}
