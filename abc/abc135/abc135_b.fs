// https://atcoder.jp/contests/abc135/submissions/11957570

let N = stdin.ReadLine() |> int
let p = stdin.ReadLine().Split() |> Array.map int

let rec resolver s n =
    if n = N then s
    elif p.[n] <> n + 1 then resolver (s + 1) (n + 1)
    else resolver s (n + 1)

if resolver 0 0 < 3 then "YES"
else "NO"
|> stdout.WriteLine
