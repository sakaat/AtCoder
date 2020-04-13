// https://atcoder.jp/contests/abc157/submissions/11871973

open System.Linq
open System.Collections.Generic

let [| N; M |] = stdin.ReadLine().Split() |> Array.map int

let S = new List<int []>()

for i in [ 1..M ] do
    stdin.ReadLine().Split()
    |> Array.map int
    |> S.Add

let result = new List<string>()

for i in [ 0..999 ] do
    let s = i.ToString()
    if s.Length = N then
        if S.All(fun x -> (s.[x.[0] - 1] |> int) - ('0' |> int) = x.[1]) then s |> result.Add

if result.Count > 0 then result.[0]
else "-1"
|> stdout.WriteLine
