// https://atcoder.jp/contests/abc149/submissions/12184048

let X = stdin.ReadLine() |> int

let inline sqrtInt n =
    n
    |> float
    |> sqrt
    |> int

let isPrime x =
    let rec loop n =
        if n <= 1 then true
        elif x % n = 0 then false
        else loop (n - 1)
    loop (sqrtInt x)

let rec solver x =
    if isPrime x then x
    else solver (x + 1)

solver X |> stdout.WriteLine
