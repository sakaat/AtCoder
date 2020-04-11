// https://atcoder.jp/contests/abc161/submissions/11738785

let input = stdin.ReadLine().Split() |> Array.map int
let N = input.[0]
let M = input.[1]

let A = stdin.ReadLine().Split() |> Array.map int
let sum = A |> Array.sum

if ((A
     |> Array.filter (fun x -> x * 4 * M >= sum)
     |> Array.length) < M)
then "No"
else "Yes"
|> printfn "%s"
