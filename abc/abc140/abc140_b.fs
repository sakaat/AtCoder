// https://atcoder.jp/contests/abc140/submissions/12018234

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int
let B = stdin.ReadLine().Split() |> Array.map int
let C = stdin.ReadLine().Split() |> Array.map int

let rec solver p r i =
    if i = N then r
    elif p + 1 = A.[i] then solver A.[i] (r + B.[A.[i] - 1] + C.[p - 1]) (i + 1)
    else solver A.[i] (r + B.[A.[i] - 1]) (i + 1)

solver -1 0 0 |> stdout.WriteLine
