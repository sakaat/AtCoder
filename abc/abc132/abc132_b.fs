// https://atcoder.jp/contests/abc132/submissions/11967721

let n = stdin.ReadLine() |> int
let p = stdin.ReadLine().Split() |> Array.map int

let rec solver s i =
    if i = n - 1 then s
    elif p.[i - 1] < p.[i] && p.[i] < p.[i + 1] || p.[i + 1] < p.[i] && p.[i] < p.[i - 1] then solver (s + 1) (i + 1)
    else solver s (i + 1)

solver 0 1 |> stdout.WriteLine
