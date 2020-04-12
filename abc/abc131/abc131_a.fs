// https://atcoder.jp/contests/abc131/submissions/11785731

let S = stdin.ReadLine()

if (S.[0] = S.[1] || S.[1] = S.[2] || S.[2] = S.[3]) then "Bad"
else "Good"
|> stdout.WriteLine
