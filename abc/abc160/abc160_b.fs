// https://atcoder.jp/contests/abc160/submissions/11749116

let X = stdin.ReadLine() |> int64

1000L * (X / 500L) + 5L * (X % 500L / 5L) |> printfn "%d"
