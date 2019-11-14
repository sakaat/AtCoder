// https://atcoder.jp/contests/abc124/submissions/8425565

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = 0;
            for (int i = 0; i < 2; i++)
            {
                if (input[0] > input[1])
                {
                    result += input[0];
                    input[0]--;
                }
                else
                {
                    result += input[1];
                    input[1]--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
