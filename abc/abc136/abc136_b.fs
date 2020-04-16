// https://atcoder.jp/contests/abc136/submissions/11990727

let N = stdin.ReadLine() |> int

let rec resolver s i =
    if i = N + 1 then s
    elif i.ToString().Length % 2 = 1 then resolver (s + 1) (i + 1)
    else resolver s (i + 1)

resolver 0 1 |> stdout.WriteLine
