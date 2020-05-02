// https://atcoder.jp/contests/abc165/submissions/12651140

let K = stdin.ReadLine() |> int
let [| A; B |] = stdin.ReadLine().Split() |> Array.map int

if A % K = 0 || A + (K - A % K) <= B then "OK"
else "NG"
|> stdout.WriteLine
