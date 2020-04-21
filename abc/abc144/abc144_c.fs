// https://atcoder.jp/contests/abc144/submissions/12055089

let N = stdin.ReadLine() |> int64

let rec solver i =
    if N % i <> 0L then solver (i - 1L)
    else i + N / i - 2L

solver
    (N
     |> float
     |> sqrt
     |> floor
     |> int64)
|> stdout.WriteLine
