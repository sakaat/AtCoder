// https://atcoder.jp/contests/abc136/submissions/11990727

let N = stdin.ReadLine() |> int

let rec solver s i =
    if i = N + 1 then s
    elif i.ToString().Length % 2 = 1 then solver (s + 1) (i + 1)
    else solver s (i + 1)

solver 0 1 |> stdout.WriteLine
