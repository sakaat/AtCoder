// https://atcoder.jp/contests/abc132/submissions/11967782

let N = stdin.ReadLine() |> int

let d =
    stdin.ReadLine().Split()
    |> Array.map int
    |> Array.sort

d.[N / 2] - d.[N / 2 - 1] |> stdout.WriteLine
