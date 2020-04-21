// https://atcoder.jp/contests/abc156/submissions/11879844

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int

let rec solver r n =
    match n with
    | n when n > 0 -> solver (r + 1) (n / K)
    | _ -> r

solver 0 N |> stdout.WriteLine
