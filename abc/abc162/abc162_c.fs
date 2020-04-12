// https://atcoder.jp/contests/abc162/submissions/11859490

let K = stdin.ReadLine() |> int

let rec gcd a b =
    match (a, b) with
    | (x, 0) -> x
    | (0, y) -> y
    | (a, b) -> gcd b (a % b)

seq {
    for i in 1..K do
        for j in 1..K do
            for k in 1..K do
                yield gcd i (gcd j k)
}
|> Seq.sum
|> stdout.WriteLine
