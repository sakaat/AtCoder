// https://atcoder.jp/contests/abc137/submissions/11991568

open System
open System.Collections.Generic

let N = stdin.ReadLine() |> int
let dic = new Dictionary<string, int64>()

let rec resolver s i =
    if i = N then s
    else
        let rs =
            stdin.ReadLine().ToCharArray()
            |> Array.sort
            |> fun x -> new String(x)
        if dic.ContainsKey(rs) then dic.[rs] <- dic.[rs] + 1L
        else dic.[rs] <- 0L
        resolver (s + dic.[rs]) (i + 1)

resolver 0L 0 |> stdout.WriteLine
