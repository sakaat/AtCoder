// https://atcoder.jp/contests/abc151/submissions/11937899

let [| N; K; M |] = stdin.ReadLine().Split() |> Array.map int

let As =
    stdin.ReadLine().Split()
    |> Array.map int
    |> Array.sum

match N * M - As with
| x when x > K -> -1
| x when x > 0 -> x
| _ -> 0
|> stdout.WriteLine
