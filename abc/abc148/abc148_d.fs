// https://atcoder.jp/contests/abc148/submissions/12180973

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int

let rec resolver s i =
    if i = N then N - s + 1
    elif A.[i] = s then resolver (s + 1) (i + 1)
    else resolver s (i + 1)

if not (A |> Array.contains 1) then -1
else resolver 1 0
|> stdout.Write
