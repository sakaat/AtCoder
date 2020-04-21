// https://atcoder.jp/contests/abc123/submissions/12197102

let x = Array.zeroCreate<int> 6

for i in [ 0..5 ] do
    x.[i] <- stdin.ReadLine() |> int

if x.[4] - x.[0] > x.[5] then ":("
else "Yay!"
|> stdout.WriteLine
