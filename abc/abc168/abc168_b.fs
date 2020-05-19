// https://atcoder.jp/contests/abc168/submissions/13388997

let K = stdin.ReadLine() |> int

stdin.ReadLine()
|> fun S ->
    if S.Length > K then S.Substring(0, K) + "..."
    else S
|> stdout.WriteLine
