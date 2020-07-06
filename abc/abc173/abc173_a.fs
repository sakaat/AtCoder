// https://atcoder.jp/contests/abc173/submissions/15019571

stdin.ReadLine()
|> int
|> fun N ->
    if N % 1000 = 0 then 0
    else (N / 1000 + 1) * 1000 - N
|> stdout.WriteLine
