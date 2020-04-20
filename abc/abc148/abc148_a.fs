// https://atcoder.jp/contests/abc148/submissions/12180371

let A = stdin.ReadLine() |> int
let B = stdin.ReadLine() |> int

if A + B = 3 then 3
elif A + B = 4 then 2
else 1
|> stdout.WriteLine
