// https://atcoder.jp/contests/abc171/submissions/14593164

let N = stdin.ReadLine() |> int64

let rec solver n =
    let q = n / 26L
    let r = n % 26L
    if q > 0L then solver (q - 1L)
    stdout.Write(char (int 'a' + int r))

solver (N - 1L)
