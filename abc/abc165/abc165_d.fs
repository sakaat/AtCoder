// https://atcoder.jp/contests/abc165/submissions/12653659

let [| A; B; N |] = stdin.ReadLine().Split() |> Array.map int64

let solver x = (A * x / B) - (A * (x / B))

solver (min (B - 1L) N) |> stdout.WriteLine
