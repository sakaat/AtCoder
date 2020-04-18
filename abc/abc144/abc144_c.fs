// https://atcoder.jp/contests/abc144/submissions/12055089

let N = stdin.ReadLine() |> int64

let rec resolver i =
    if N % i <> 0L then resolver (i - 1L)
    else i + N / i - 2L

resolver
    (N
     |> float
     |> sqrt
     |> floor
     |> int64)
|> stdout.WriteLine
