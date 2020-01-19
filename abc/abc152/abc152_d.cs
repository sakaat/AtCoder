// https://atcoder.jp/contests/abc152/submissions/9627413

using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var table = new int[10, 10];
            for (int i = 1; i <= N; i++)
            {
                table[FirstDigit(i), i % 10]++;
            }

            var result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += table[i % 10, FirstDigit(i)];
            }
            Console.WriteLine(result);
        }

        static int FirstDigit(int num)
        {
            while (num >= 10)
            {
                num /= 10;
            }
            return num;
        }
    }
}
