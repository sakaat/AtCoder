// https://atcoder.jp/contests/abc134/submissions/11973045

let N = stdin.ReadLine() |> int

let A =
    [| for _ in [ 1..N ] do
        yield stdin.ReadLine() |> int |]

let As = A |> Array.sortDescending

A
|> Array.map (fun x ->
    if x = As.[0] then As.[1]
    else As.[0])
|> Array.iter stdout.WriteLine
