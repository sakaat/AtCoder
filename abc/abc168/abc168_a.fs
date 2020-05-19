// https://atcoder.jp/contests/abc168/submissions/13388975

stdin.ReadLine()
|> int
|> fun N ->
    match N % 10 with
    | 3 -> "bon"
    | 0
    | 1
    | 6
    | 8 -> "pon"
    | _ -> "hon"
    |> stdout.WriteLine
