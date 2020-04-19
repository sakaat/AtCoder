// https://atcoder.jp/contests/abc145/submissions/12154829

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine()

if N % 2 > 0 then "No"
elif S.Substring(0, N / 2) <> S.Substring(N / 2, N / 2) then "No"
else "Yes"
|> stdout.WriteLine
