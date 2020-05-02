// https://atcoder.jp/contests/abc165/submissions/12651801

let X = stdin.ReadLine() |> int64

let rec solver m n =
    if m >= X then n
    else solver (int64 ((float m) * 1.01)) (n + 1)

solver 100L 0 |> stdout.WriteLine
