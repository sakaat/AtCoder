// https://atcoder.jp/contests/abc123/submissions/8438152

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var input = new int[5].Select(_ => int.Parse(Console.ReadLine())).ToArray();

            var index = 0;
            var value = input[0] % 10;
            for (int i = 0; i < 5; i++)
            {
                if (0 < input[i] % 10 && input[i] % 10 < value)
                {
                    value = input[i] % 10;
                    index = i;
                }
            }

            var result = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i != index)
                {
                    result += (int)Math.Ceiling(input[i] / 10.0) * 10;
                }
                else
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
