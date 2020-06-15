// https://atcoder.jp/contests/abc170/submissions/14373994

let [| X; Y |] = stdin.ReadLine().Split() |> Array.map int

[ for i in 0..X -> 2 * i + 4 * (X - i) ]
|> List.contains Y
|> fun b ->
    if b then "Yes"
    else "No"
|> stdout.WriteLine
