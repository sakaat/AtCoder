// https://atcoder.jp/contests/abc139/submissions/12017309

stdin.ReadLine()
|> int64
|> fun N -> N * (N - 1L) / 2L
|> stdout.WriteLine
