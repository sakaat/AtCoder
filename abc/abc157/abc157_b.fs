// https://atcoder.jp/contests/abc157/submissions/11872711

open System.Collections.Generic

let A = new List<int []>()

for i in [ 1..3 ] do
    stdin.ReadLine().Split()
    |> Array.map int
    |> A.Add

let N = stdin.ReadLine() |> int

let b = new List<int>()

for i in [ 1..N ] do
    stdin.ReadLine()
    |> int
    |> b.Add

let mutable C = new List<bool []>()

for i in [ 1..3 ] do
    [| false; false; false |] |> C.Add

for i in [ 0..N - 1 ] do
    for j in [ 0..2 ] do
        for k in [ 0..2 ] do
            if A.[j].[k] = b.[i] then C.[j].[k] <- true

let mutable result = false

for i in [ 0..2 ] do
    if C.[i].[0] && C.[i].[1] && C.[i].[2] then result <- true
    if C.[0].[i] && C.[1].[i] && C.[2].[i] then result <- true
if C.[0].[0] && C.[1].[1] && C.[2].[2] then result <- true
if C.[2].[0] && C.[1].[1] && C.[0].[2] then result <- true

if result then "Yes"
else "No"
|> stdout.WriteLine
