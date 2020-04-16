// https://atcoder.jp/contests/abc132/submissions/11967721

let n = stdin.ReadLine() |> int
let p = stdin.ReadLine().Split() |> Array.map int

let rec resolver s i =
    if i = n - 1 then s
    elif p.[i - 1] < p.[i] && p.[i] < p.[i + 1] || p.[i + 1] < p.[i] && p.[i] < p.[i - 1] then resolver (s + 1) (i + 1)
    else resolver s (i + 1)

resolver 0 1 |> stdout.WriteLine
