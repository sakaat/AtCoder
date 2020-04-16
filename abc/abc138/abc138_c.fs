// https://atcoder.jp/contests/abc138/submissions/11992529

let N = stdin.ReadLine() |> int

let v =
    stdin.ReadLine().Split()
    |> Array.map float
    |> Array.sortDescending

let rec resolver l =
    if l <= 1 then ()
    else
        v.[l - 2] <- (v.[l - 2] + v.[l - 1]) / 2.0
        resolver (l - 1)

resolver v.Length
v.[0] |> stdout.WriteLine
