// https://atcoder.jp/contests/abc147/submissions/12162728

open System

let N = stdin.ReadLine() |> int

let A = Array.zeroCreate<int> N
let xy = Array.zeroCreate<int [] []> N

for i in [ 0..N - 1 ] do
    A.[i] <- stdin.ReadLine() |> int
    xy.[i] <- Array.zeroCreate<int []> A.[i]
    for j in [ 0..A.[i] - 1 ] do
        xy.[i].[j] <- stdin.ReadLine().Split() |> Array.map int

let mutable result = 0

for i in [ (pown 2 N) - 1..-1..0 ] do
    let mutable flag = true
    let s = Convert.ToString(i, 2).PadLeft(N, '0')

    let sl =
        s.ToCharArray()
        |> Array.filter (fun x -> x = '1')
        |> Array.length
    for j in [ 0..N - 1 ] do
        if s.[j] <> '0' then
            for k in [ 0..A.[j] - 1 ] do
                if not flag || xy.[j].[k].[1] <> int s.[xy.[j].[k].[0] - 1] - int '0' then flag <- false
    if flag && sl > result then result <- sl

result |> stdout.WriteLine
