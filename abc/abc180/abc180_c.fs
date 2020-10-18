// https://atcoder.jp/contests/abc180/submissions/17491386

let N = stdin.ReadLine() |> int64

let rec solver (x : int64 list) i =
    if i * i > N then x
    elif N % i = 0L && N / i <> i then solver (i :: N / i :: x) (i + 1L)
    elif N % i = 0L then solver (i :: x) (i + 1L)
    else solver x (i + 1L)

solver [] 1L
|> List.sort
|> List.iter stdout.WriteLine