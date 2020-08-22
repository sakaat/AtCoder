// https://atcoder.jp/contests/abc176/submissions/16151964

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int64

let rec solver s m i =
    if i = N then s
    elif A.[i] < m then solver (s + m - A.[i]) m (i + 1)
    else solver s A.[i] (i + 1)

solver 0L A.[0] 1 |> stdout.WriteLine
