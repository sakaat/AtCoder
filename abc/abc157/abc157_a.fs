// https://atcoder.jp/contests/abc157/submissions/11872051

let N = stdin.ReadLine() |> int

if N % 2 = 0 then N / 2
else N / 2 + 1
|> stdout.WriteLine
