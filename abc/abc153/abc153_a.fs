// https://atcoder.jp/contests/abc153/submissions/11914596

let [| H; A |] = stdin.ReadLine().Split() |> Array.map float

H / A
|> ceil
|> stdout.WriteLine
