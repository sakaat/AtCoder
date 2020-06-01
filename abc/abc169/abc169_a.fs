// https://atcoder.jp/contests/abc169/submissions/13904490

stdin.ReadLine().Split()
|> Array.map int
|> fun x -> x.[0] * x.[1]
|> stdout.WriteLine
