// https://atcoder.jp/contests/abc175/submissions/15961890

match stdin.ReadLine() with
| "SSS" -> 0
| "SSR"
| "SRS"
| "RSS"
| "RSR" -> 1
| "SRR"
| "RRS" -> 2
| "RRR" -> 3
|> stdout.WriteLine
