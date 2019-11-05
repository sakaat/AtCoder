// https://atcoder.jp/contests/abc141/submissions/7520958

using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        var flag = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0 &&
                input[i] != 'R' && input[i] != 'U' && input[i] != 'D')
            {
                flag = false;
            }
            else if (i % 2 == 1 &&
                input[i] != 'L' && input[i] != 'U' && input[i] != 'D')
            {
                flag = false;
            }
        }
        Console.WriteLine(flag ? "Yes" : "No");
    }
}
