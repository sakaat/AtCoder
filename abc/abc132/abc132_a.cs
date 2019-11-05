// https://atcoder.jp/contests/abc132/submissions/8272517

using System;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input[0] == input[1] && input[1] != input[2] && input[2] == input[3]
                || input[0] == input[2] && input[2] != input[1] && input[1] == input[3]
                || input[0] == input[3] && input[3] != input[1] && input[1] == input[2])
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
