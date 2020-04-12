// https://atcoder.jp/contests/abc131/submissions/11783080

let [| A; B; C; D |] = stdin.ReadLine().Split() |> Array.map int64

let rec gcd a b =
    match (a, b) with
    | (x, 0L) -> x
    | (0L, y) -> y
    | (a, b) -> gcd b (a % b)

let lcm a b = a * b / (gcd a b)

let resolver x = x - x / C - x / D + x / (lcm C D)

resolver B - resolver (A - 1L) |> stdout.WriteLine
