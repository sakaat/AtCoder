// https://atcoder.jp/contests/abc135/submissions/11957570

let N = stdin.ReadLine() |> int
let p = stdin.ReadLine().Split() |> Array.map int

let rec solver s n =
    if n = N then s
    elif p.[n] <> n + 1 then solver (s + 1) (n + 1)
    else solver s (n + 1)

if solver 0 0 < 3 then "YES"
else "NO"
|> stdout.WriteLine
