// https://atcoder.jp/contests/abc162/submissions/11863358

open System
open System.Collections.Generic

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine()

let R = new List<int>()
let G = new List<int>()
let B = new List<int>()

for i in [ 0..N - 1 ] do
    match S.[i] with
    | 'R' -> R.Add(i)
    | 'G' -> G.Add(i)
    | 'B' -> B.Add(i)

let mutable result = 0L
let mutable count = ref 0

for i in 0..R.Count - 1 do
    let ix = R.[i]
    for j in 0..G.Count - 1 do
        let jx = G.[j]

        let m = (ix, jx) |> Math.Min
        let M = (ix, jx) |> Math.Max
        let d = M - m

        if B.Contains(M + d) then incr count
        if B.Contains(m - d) then incr count
        if (M + m) % 2 = 0 && B.Contains((M + m) / 2) then incr count
        result <- result + (B.Count |> int64)

result - (!count |> int64) |> stdout.WriteLine
