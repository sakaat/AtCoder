// https://atcoder.jp/contests/abc120/submissions/16642457

stdin.ReadLine().Split()
|> Array.map int
|> fun x -> min x.[2] (x.[1] / x.[0])
|> stdout.WriteLine
