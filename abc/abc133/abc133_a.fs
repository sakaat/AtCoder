// https://atcoder.jp/contests/abc133/submissions/11968543

let [| N; A; B |] = stdin.ReadLine().Split() |> Array.map int

min (N * A) B |> stdout.WriteLine
