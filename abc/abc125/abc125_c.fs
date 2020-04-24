// https://atcoder.jp/contests/abc125/submissions/12277287

let rec gcd a b =
    match (a, b) with
    | (x, 0) -> x
    | (0, y) -> y
    | (a, b) -> gcd b (a % b)

let N = stdin.ReadLine() |> int
let A = stdin.ReadLine().Split() |> Array.map int

let l = Array.scan gcd 0 A |> Array.take N
let r = Array.scanBack gcd A 0 |> Array.skip 1

Array.zip l r
|> Array.map (fun x -> gcd (fst x) (snd x))
|> Array.max
|> stdout.WriteLine
