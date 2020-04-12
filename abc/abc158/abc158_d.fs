// https://atcoder.jp/contests/abc158/submissions/11770667

open System.Collections.Generic
open System.Linq

let S = stdin.ReadLine()
let Q = stdin.ReadLine() |> int

let mutable flag = true
let ll = new LinkedList<char>()

'*'
|> ll.AddLast
|> ignore

for i in [ 0..Q - 1 ] do
    let input = stdin.ReadLine()
    if (input.[0] = '1') then flag <- not flag
    else
        let q = input.Split().ToArray()
        match flag with
        | true ->
            if (q.[1] = "1") then
                q.[2]
                |> char
                |> ll.AddFirst
                |> ignore
            else
                q.[2]
                |> char
                |> ll.AddLast
                |> ignore
        | false ->
            if (q.[1] = "1") then
                q.[2]
                |> char
                |> ll.AddLast
                |> ignore
            else
                q.[2]
                |> char
                |> ll.AddFirst
                |> ignore

let str = (new string(ll.ToArray())).Replace("*", S)

if flag then str
else new string(str.Reverse().ToArray())
|> printfn "%s"
