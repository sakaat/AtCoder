// https://atcoder.jp/contests/abc172/submissions/14784108

let N = stdin.ReadLine() |> int64

let rec solver i sum =
    if i = N + 1L then sum
    else
        let q = N / i
        solver (i + 1L) (sum + q * (q + 1L) * i / 2L)

solver 1L 0L |> stdout.WriteLine
