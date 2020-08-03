// https://atcoder.jp/contests/abc174/submissions/15652998

let K = stdin.ReadLine() |> int

let rec solver q i =
    if q = 0 then i
    elif K < i then -1
    else solver ((10 * q + 7) % K) (i + 1)

solver (7 % K) 1 |> stdout.WriteLine
