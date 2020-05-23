// https://atcoder.jp/contests/past201912-open/submissions/13492469

stdin.ReadLine().Split()
|> Array.map int
|> Array.sortDescending
|> fun A -> A.[2]
|> stdout.WriteLine
