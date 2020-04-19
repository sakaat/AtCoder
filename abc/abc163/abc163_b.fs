// https://atcoder.jp/contests/abc163/submissions/12139163

let [| N; _ |] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int

let days = N - Array.sum A

if days >= 0 then days
else -1
|> stdout.WriteLine
