// https://atcoder.jp/contests/abc164/submissions/12399892

let N = stdin.ReadLine() |> int

let S = Array.zeroCreate<string> N

for i in [ 0..N - 1 ] do
    S.[i] <- stdin.ReadLine()

S
|> Array.distinct
|> Array.length
|> stdout.WriteLine
