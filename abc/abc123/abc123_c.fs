// https://atcoder.jp/contests/abc123/submissions/12198540

let N = stdin.ReadLine() |> float

let cities = Array.zeroCreate<float> 5

for i in [ 0..4 ] do
    cities.[i] <- stdin.ReadLine() |> float

N / (Array.min cities) + 4.
|> ceil
|> int64
|> stdout.WriteLine
