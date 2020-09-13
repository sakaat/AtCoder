// https://atcoder.jp/contests/abc178/submissions/16727243

let [| a; b; c; d |] = stdin.ReadLine().Split() |> Array.map int64

max (max (a * c) (a * d)) (max (b * c) (b * d)) |> stdout.WriteLine
