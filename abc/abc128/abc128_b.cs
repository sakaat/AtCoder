// https://atcoder.jp/contests/abc128/submissions/8305932

using System;
using System.Linq;

namespace CSharp
{
    class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());

            var restaurant = new Restaurant[N];
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                restaurant[i] = new Restaurant(i, input[0], int.Parse(input[1]));
            }
            var sortList = restaurant.OrderBy(x => x.s).ThenByDescending(x => x.p);

            foreach (var r in sortList)
            {
                Console.WriteLine(r.id + 1);
            }
        }
    }

    class Restaurant
    {
        public int id;
        public string s;
        public int p;

        public Restaurant(int id, string s, int p)
        {
            this.id = id;
            this.s = s;
            this.p = p;
        }
    }
}
