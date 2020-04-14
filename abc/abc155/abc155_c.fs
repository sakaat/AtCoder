// https://atcoder.jp/contests/abc155/submissions/11910212

let N = stdin.ReadLine() |> int

let S =
    [| for _ in 1..N -> stdin.ReadLine() |]
    |> Array.countBy id

let max =
    S
    |> Array.maxBy snd
    |> snd

S
|> Array.filter (fun x -> (x |> snd) = max)
|> Array.sortBy fst
|> Array.map fst
|> Array.iter stdout.WriteLine
