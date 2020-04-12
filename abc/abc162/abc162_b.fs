// https://atcoder.jp/contests/abc162/submissions/11856931

let N = stdin.ReadLine() |> int64

let rec resolver s n =
    match n with
    | i when i = N + 1L -> s
    | i when i % 3L > 0L && i % 5L > 0L -> resolver (s + n) (n + 1L)
    | _ -> resolver s (n + 1L)

resolver 0L 0L |> stdout.WriteLine
