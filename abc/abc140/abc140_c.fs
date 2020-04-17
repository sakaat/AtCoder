// https://atcoder.jp/contests/abc140/submissions/12019154

let N = stdin.ReadLine() |> int
let B = stdin.ReadLine().Split() |> Array.map int

[ 1..(N - 2) ]
|> List.map (fun i -> min B.[i - 1] B.[i])
|> List.sum
|> fun x -> B.[0] + x + B.[N - 2]
|> stdout.WriteLine
