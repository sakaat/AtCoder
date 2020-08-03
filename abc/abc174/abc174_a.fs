// https://atcoder.jp/contests/abc174/submissions/15640744

stdin.ReadLine()
|> int
|> fun x ->
    if x >= 30 then "Yes"
    else "No"
|> stdout.WriteLine
