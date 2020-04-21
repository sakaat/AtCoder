// https://atcoder.jp/contests/abc150/submissions/12184146

let [| K; X |] = stdin.ReadLine().Split() |> Array.map int

if K * 500 >= X then "Yes"
else "No"
|> stdout.WriteLine
