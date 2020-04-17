// https://atcoder.jp/contests/abc139/submissions/12017862

let N = stdin.ReadLine() |> int
let H = stdin.ReadLine().Split() |> Array.map float

let rec resolver t r i =
    if i = N - 1 then r
    elif H.[i + 1] <= H.[i] then resolver (t + 1) (max r (t + 1)) (i + 1)
    else resolver 0 r (i + 1)

resolver 0 0 0 |> stdout.WriteLine
