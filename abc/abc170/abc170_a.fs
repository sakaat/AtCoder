// https://atcoder.jp/contests/abc170/submissions/14373915

stdin.ReadLine().Split()
|> Array.map int
|> Array.sum
|> fun x -> 15 - x
|> stdout.WriteLine
