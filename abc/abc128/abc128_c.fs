// https://atcoder.jp/contests/abc128/submissions/12226417

open System

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

let s = Array.zeroCreate<int []> M

for i in [ 0..M - 1 ] do
    s.[i] <- stdin.ReadLine().Split()
             |> Array.skip 1
             |> Array.map int

let p = stdin.ReadLine().Split() |> Array.map int

let mutable result = 0

for i in [ 0..pown 2 N - 1 ] do
    let c = Convert.ToString(i, 2).PadLeft(N, '0').ToCharArray()
    let mutable flag = true
    for j in [ 0..M - 1 ] do
        if flag then
            let mutable t = 0
            for k in [ 0..(s.[j] |> Array.length) - 1 ] do
                t <- t + int c.[s.[j].[k] - 1]
            if t % 2 <> p.[j] then flag <- false
    if flag then result <- result + 1

result |> stdout.WriteLine
