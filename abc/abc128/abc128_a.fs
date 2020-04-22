// https://atcoder.jp/contests/abc128/submissions/12223442

let [| A; P |] = stdin.ReadLine().Split() |> Array.map int

(3 * A + P) / 2 |> stdout.WriteLine
