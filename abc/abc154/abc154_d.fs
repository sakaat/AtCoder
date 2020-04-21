// https://atcoder.jp/contests/abc154/submissions/11914250

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int
let p = stdin.ReadLine().Split() |> Array.map int

let m =
    p
    |> Array.take K
    |> Array.sum

let rec solver m t n =
    match n with
    | n when n = N - K + 1 -> ((m + K) |> float) / 2.0
    | _ ->
        let s = t + p.[n + K - 1] - p.[n - 1]
        solver (max s m) s (n + 1)

solver m m 1 |> stdout.WriteLine
