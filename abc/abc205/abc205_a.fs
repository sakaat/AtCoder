// https://atcoder.jp/contests/abc205/submissions/23917776

let [| A; B |] = stdin.ReadLine().Split() |> Array.map float

A * B / 100.0 |> stdout.WriteLine
