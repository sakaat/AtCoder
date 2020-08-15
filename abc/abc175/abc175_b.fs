// https://atcoder.jp/contests/abc175/submissions/15962132

let N = stdin.ReadLine() |> int

let L =
    stdin.ReadLine().Split()
    |> Array.map int
    |> Array.sort

let isDifferent3 x y z =
    if x <> y && y <> z && z <> x then true
    else false

let rec solver r i j k =
    if i = N then r
    elif j = N then solver r (i + 1) (i + 2) (i + 3)
    elif k = N then solver r i (j + 1) (j + 2)
    elif isDifferent3 L.[i] L.[j] L.[k] && L.[i] + L.[j] > L.[k] then solver (r + 1) i j (k + 1)
    else solver r i j (k + 1)

solver 0 0 1 2 |> stdout.WriteLine
