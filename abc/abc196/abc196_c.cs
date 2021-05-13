// https://atcoder.jp/contests/abc196/submissions/22557536

using System;

class Program
{
    static void Main()
    {
        var N = long.Parse(Console.ReadLine());
        var i = 1;
        while (true)
        {
            if (long.Parse(string.Concat(i.ToString(), i.ToString())) > N)
            {
                Console.WriteLine(i - 1);
                break;
            }
            i++;
        }
    }
}
