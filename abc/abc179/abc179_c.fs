// https://atcoder.jp/contests/abc179/submissions/16893345

let N = stdin.ReadLine() |> int

let rec solver r i =
    if i = N then r
    else solver (r + (N - 1) / i) (i + 1)

solver 0 1 |> stdout.WriteLine
