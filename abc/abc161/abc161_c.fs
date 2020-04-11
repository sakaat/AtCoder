// https://atcoder.jp/contests/abc161/submissions/11738694

let input = stdin.ReadLine().Split() |> Array.map int64
let N = input.[0]
let K = input.[1]

min (N % K) (K - (N % K)) |> printfn "%d"
