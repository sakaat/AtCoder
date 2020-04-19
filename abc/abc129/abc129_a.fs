// https://atcoder.jp/contests/abc129/submissions/12151182

stdin.ReadLine().Split()
|> Array.map int
|> fun x -> (Array.sum x - Array.max x)
|> stdout.WriteLine
