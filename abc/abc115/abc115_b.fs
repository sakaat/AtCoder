// https://atcoder.jp/contests/abc115/submissions/16817863

let N = stdin.ReadLine() |> int

[ for i in [ 0..N - 1 ] do
    yield (stdin.ReadLine() |> int) ]
|> fun x -> (List.sum x - List.max x / 2)
|> stdout.WriteLine
