// https://atcoder.jp/contests/abc156/submissions/11878988

let N = stdin.ReadLine() |> int
let X = stdin.ReadLine().Split() |> Array.map int64

let p =
    X
    |> Array.averageBy float
    |> round
    |> int64

X
|> Array.sumBy (fun x -> (x - p) * (x - p))
|> stdout.WriteLine
