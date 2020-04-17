// https://atcoder.jp/contests/abc140/submissions/12018234

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int
let B = stdin.ReadLine().Split() |> Array.map int
let C = stdin.ReadLine().Split() |> Array.map int

let rec resolver p r i =
    if i = N then r
    elif p + 1 = A.[i] then resolver A.[i] (r + B.[A.[i] - 1] + C.[p - 1]) (i + 1)
    else resolver A.[i] (r + B.[A.[i] - 1]) (i + 1)

resolver -1 0 0 |> stdout.WriteLine
