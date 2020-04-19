// https://atcoder.jp/contests/abc163/submissions/12146120

let N = stdin.ReadLine() |> int

let A =
    stdin.ReadLine().Split()
    |> Array.map int
    |> Array.countBy id
    |> dict

[| 1..N |]
|> Array.map (fun x ->
    if A.ContainsKey x then A.[x]
    else 0)
|> Array.iter stdout.WriteLine
