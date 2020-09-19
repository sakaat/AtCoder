// https://atcoder.jp/contests/abc179/submissions/16890295

let S = stdin.ReadLine()

match S.[S.Length - 1] with
| 's' -> S + "es"
| _ -> S + "s"
|> stdout.WriteLine
