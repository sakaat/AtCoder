// https://atcoder.jp/contests/abc201/submissions/22777630

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var result = false;
        if (A[2] - A[1] == A[1] - A[0]
            || A[1] - A[2] == A[2] - A[0]
            || A[2] - A[0] == A[0] - A[1]
            || A[0] - A[2] == A[2] - A[1]
            || A[1] - A[0] == A[0] - A[2]
            || A[0] - A[1] == A[1] - A[2])
        {
            result = true;
        }
        Console.WriteLine(result ? "Yes" : "No");
    }
}
