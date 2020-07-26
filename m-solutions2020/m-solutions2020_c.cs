// https://atcoder.jp/contests/m-solutions2020/submissions/15466564

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var K = input[1];
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = K; i < A.Length; i++)
        {
            if (A[i - K] < A[i])
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
