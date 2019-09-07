// https://atcoder.jp/contests/abs/submissions/7035179

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        if (input[0] * input[1] % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}
