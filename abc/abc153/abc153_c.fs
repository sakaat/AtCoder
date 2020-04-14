// https://atcoder.jp/contests/abc153/submissions/11915085

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int

stdin.ReadLine().Split()
|> Array.map int64
|> Array.sortDescending
|> Array.skip (min N K)
|> Array.sum
|> stdout.WriteLine
