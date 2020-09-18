// https://atcoder.jp/contests/abc115/submissions/16817797

let d = "Christmas"

match stdin.ReadLine() |> int with
| 25 -> d
| 24 -> d + " Eve"
| 23 -> d + " Eve Eve"
| 22 -> d + " Eve Eve Eve"
|> stdout.WriteLine
