// https://atcoder.jp/contests/abc169/submissions/13927255

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int64

let rec solver prod n =
    if n = N then prod
    else
        let tmp = prod * A.[n]
        if (tmp < prod || tmp > 1000000000000000000L) then -1L
        else solver (prod * A.[n]) (n + 1)

if (Array.contains 0L A) then 0L
else solver 1L 0
|> stdout.WriteLine
