// https://atcoder.jp/contests/abc177/submissions/16376925

let MOD = 1000000007L
let add x y = (x + y) % MOD
let sub x y = (x + MOD - y) % MOD

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int64

let mutable sum = 0L

for i in [ 0..N - 1 ] do
    sum <- add sum A.[i]

let mutable result = 0L

for i in [ 0..N - 1 ] do
    sum <- sub sum A.[i]
    if sum < 0L then sum <- add sum MOD
    result <- add result (A.[i] * sum)

result |> stdout.WriteLine
