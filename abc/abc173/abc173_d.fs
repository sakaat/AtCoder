// https://atcoder.jp/contests/abc173/submissions/15065387

let N = stdin.ReadLine() |> int64

let A =
    stdin.ReadLine().Split()
    |> Array.map int64
    |> Array.sortDescending

let rec solver s i =
    if i = N - 1L then s
    else solver (s + A.[int ((i + 1L) / 2L)]) (i + 1L)

solver 0L 0L |> stdout.WriteLine
