// https://atcoder.jp/contests/abc148/submissions/12180793

let [| A; B |] = stdin.ReadLine().Split() |> Array.map int64

let rec gcd a b =
    match (a, b) with
    | (x, 0L) -> x
    | (0L, y) -> y
    | (a, b) -> gcd b (a % b)

let lcm a b = a * b / (gcd a b)

lcm A B |> stdout.Write
