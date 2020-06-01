// https://atcoder.jp/contests/abc169/submissions/13904506

stdin.ReadLine().Split()
|> Array.map decimal
|> fun x -> x.[0] * x.[1]
|> floor
|> stdout.WriteLine
