// https://atcoder.jp/contests/past201912-open/submissions/13492369

let N = stdin.ReadLine() |> int
let A = Array.zeroCreate<int> N

for i in [ 0..N - 1 ] do
    A.[i] <- (stdin.ReadLine() |> int)

A
|> Array.pairwise
|> Array.map (fun x ->
    match (snd x - fst x) with
    | y when y > 0 -> "up " + y.ToString()
    | y when y < 0 -> "down " + (abs y).ToString()
    | _ -> "stay")
|> Array.iter stdout.WriteLine
