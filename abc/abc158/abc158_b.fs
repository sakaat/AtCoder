// https://atcoder.jp/contests/abc158/submissions/11770838

open System

let [| N; A; B |] = stdin.ReadLine().Split() |> Array.map int64

N / (A + B) * A + Math.Min(A, N % (A + B)) |> printfn "%i"
