// https://atcoder.jp/contests/abc166/submissions/12781091

open System.Collections.Generic

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int

let s = new HashSet<int>()

for i in [ 1..K ] do
    let _ = stdin.ReadLine()
    let A = stdin.ReadLine().Split() |> Array.map int
    for j in [ 0..A.Length - 1 ] do
        s.Add(A.[j]) |> ignore

N - s.Count |> stdout.WriteLine
