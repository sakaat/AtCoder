// https://atcoder.jp/contests/abc147/submissions/12160574

stdin.ReadLine().Split()
|> Array.sumBy int
|> (fun x ->
if x >= 22 then "bust"
else "win")
|> stdout.WriteLine
