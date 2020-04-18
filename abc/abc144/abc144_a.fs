// https://atcoder.jp/contests/abc144/submissions/12054620

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

if A < 10 && B < 10 then A * B
else -1
|> stdout.WriteLine
