// https://atcoder.jp/contests/abc134/submissions/11972041

let [| N; D |] = stdin.ReadLine().Split() |> Array.map float

N / (2.0 * D + 1.0)
|> ceil
|> stdout.WriteLine
