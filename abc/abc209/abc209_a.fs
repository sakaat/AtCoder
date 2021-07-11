// https://atcoder.jp/contests/abc209/submissions/24164245

stdin.ReadLine().Split() |> Array.map int
|> fun x -> max 0 (x.[1] - x.[0] + 1)
|> stdout.WriteLine
