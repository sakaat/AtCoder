// https://atcoder.jp/contests/abc141/submissions/7515355

using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (input == "Sunny")
        {
            Console.WriteLine("Cloudy");
        }
        else if (input == "Cloudy")
        {
            Console.WriteLine("Rainy");
        }
        else if (input == "Rainy")
        {
            Console.WriteLine("Sunny");
        }
    }
}
