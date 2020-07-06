// https://atcoder.jp/contests/abc173/submissions/15019659

using System;

class Program
{
    static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        Console.WriteLine(N % 1000 == 0 ? 0 : (N / 1000 + 1) * 1000 - N);
    }
}
