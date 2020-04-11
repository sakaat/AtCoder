// https://atcoder.jp/contests/abc160/submissions/11749539

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int
let A = stdin.ReadLine().Split() |> Array.map int

let d =
    A
    |> Seq.pairwise
    |> Seq.map (fun (x, y) -> y - x)
    |> Seq.append [ A.[0] + N - A.[K - 1] ]

(d |> Seq.sum) - (d |> Seq.max) |> printfn "%d"
