// https://atcoder.jp/contests/abc143/submissions/12053467

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

max 0 (A - 2 * B) |> stdout.WriteLine
